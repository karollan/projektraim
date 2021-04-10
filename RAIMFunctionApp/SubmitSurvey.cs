using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Data.SqlClient;
using Shared.Models;


namespace RAIMFunctionApp
{
    public static class SubmitSurvey
    {
        [FunctionName("SubmitSurvey")]
        public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req, ILogger log)
        {
            User user;
            //dynamic body = await req.Content.ReadAsStringAsync();
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            int insertRecord;
            try
            {
                user = JsonConvert.DeserializeObject<User>(requestBody);
                insertRecord = InsertSurvey(user, log);
                return new OkObjectResult(user);
            }
            catch (Exception ex)
            {
                log.LogError(ex.Message);
                return new BadRequestObjectResult(ex.Message);
            }
        }

        public static int InsertSurvey(User rUser, ILogger log)
        {
            int recordsInserted;
            try
            {
                using (SqlConnection connection = new SqlConnection(Environment.GetEnvironmentVariable("SqlConnectionString")))
                {
                    var query = @"DECLARE @i INT;
                                INSERT INTO [User] (age, gender, student_eti, education, started_at, completed_at) VALUES (@Age, @Gender, @Student_eti, @Education, @Started_at, @Completed_at);
                                SELECT @i = SCOPE_IDENTITY();
                                INSERT INTO [History] (user_id, hpv, flu, chickenpox) VALUES (@i, @HPV, @Flu, @Chickenpox);
                                INSERT INTO [Knowledge_source] (user_id, source) VALUES (@i, @Source);
                                INSERT INTO [Opinion] (user_id, compulsoryvaccination, optionalvaccination, covidvaccination, covidvacsafety, diseaseorvaccine, informationtrust) VALUES (@i, @CompulsoryVaccination, @OptionalVaccination, @CovidVaccination, @CovidVacSafety, @DiseaseOrVaccine, @InformationTrust);
                                INSERT INTO [Result] (user_id, score) VALUES (@i, @Score)";


                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Age", rUser.Age);
                        cmd.Parameters.AddWithValue("@Gender", rUser.Gender);
                        cmd.Parameters.AddWithValue("@Student_eti", rUser.Student_eti);
                        cmd.Parameters.AddWithValue("@Education", rUser.Education);
                        cmd.Parameters.AddWithValue("@Started_at", rUser.Started_at);
                        cmd.Parameters.AddWithValue("@Completed_at", rUser.Completed_at);
                        cmd.Parameters.AddWithValue("@HPV", rUser.History.HPV);
                        cmd.Parameters.AddWithValue("@Flu", rUser.History.Flu);
                        cmd.Parameters.AddWithValue("@Chickenpox", rUser.History.Chickenpox);
                        cmd.Parameters.AddWithValue("@Source", rUser.KnowledgeSource.Source);
                        cmd.Parameters.AddWithValue("@CompulsoryVaccination", rUser.Opinion.CompulsoryVaccination);
                        cmd.Parameters.AddWithValue("@OptionalVaccination", rUser.Opinion.OptionalVaccination);
                        cmd.Parameters.AddWithValue("@CovidVaccination", rUser.Opinion.CovidVaccination);
                        cmd.Parameters.AddWithValue("@CovidVacSafety", rUser.Opinion.CovidVacSafety);
                        cmd.Parameters.AddWithValue("@DiseaseOrVaccine", rUser.Opinion.DiseaseOrVaccine);
                        cmd.Parameters.AddWithValue("@InformationTrust", rUser.Opinion.InformationTrust);
                        cmd.Parameters.AddWithValue("@Score", rUser.Result.Score);
                        connection.Open();
                        recordsInserted = cmd.ExecuteNonQuery();
                        connection.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                log.LogInformation(ex.Message);
                recordsInserted = 0;
            }
            return recordsInserted;
        }
    }
}
