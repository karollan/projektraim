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
using System.Net.Http;
using Shared.Models;
using Microsoft.Azure.WebJobs.Host;
using System.Configuration;
using System.Net;
using Dapper;

namespace RAIMFunctionApp
{
    public static class UserListFunction
    {
        [FunctionName("AddUser")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req, ILogger log)
        {
            User user;
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            int insertRecord;
            try
            {
                user = JsonConvert.DeserializeObject<User>(requestBody);
                insertRecord = InsertUser(user, log);
                return new OkObjectResult(user);
            }
            catch (Exception ex)
            {
                log.LogError(ex.Message);
                return new BadRequestObjectResult(ex.Message);
            }
        }

        public static int InsertUser(User rUser, ILogger log)
        {
            int recordsInserted;
            try
            {
                using (SqlConnection connection = new SqlConnection(Environment.GetEnvironmentVariable("SqlConnectionString")))
                {
                    var query = $"INSERT INTO [User] (age,gender,student_eti,education, started_at, completed_at) VALUES('{rUser.Age}', '{rUser.Gender}' , '{rUser.Student_eti}', '{rUser.Education}', '{rUser.Started_at}', '{rUser.Completed_at}')";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
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
