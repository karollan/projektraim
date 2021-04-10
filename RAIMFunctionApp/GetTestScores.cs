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
using System.Collections.Generic;

namespace RAIMFunctionApp
{
    public static class GetTestScores
    {
        [FunctionName("GetTestScores")]
        public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req, ILogger log)
        {
            List<Data> TestScores = new List<Data>();
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            using (SqlConnection connection = new SqlConnection(Environment.GetEnvironmentVariable("SqlConnectionString")))
            {
                string oString = "SELECT [score] FROM [Result]";
                SqlCommand oCmd = new SqlCommand(oString, connection);
                connection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Data data = new Data();
                        data.Y = Int32.Parse(oReader["score"].ToString());
                        TestScores.Add(data);
                    }
                    connection.Close();
                }
            }
            return new OkObjectResult(TestScores);
        }
    }
}
