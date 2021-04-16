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
    public static class QuizController
    {
        [FunctionName("GetQuiz")]
        public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req, ILogger log)
        {
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            List<QuizItem> Quiz = new List<QuizItem>
            {
                new QuizItem
                {
                    Question = "Czym różnią się szczepienia obowiązkowe od zalecanych?",
                    Choices = new List<string> { "Szczepienia obowiązkowe obejmują kwalifikację do szczepienia, natomiast zalecanych to nie dotyczy", "Szczepienia obowiązkowe są ważne, a zalecane mniej ważne", "Szczepienia obowiązkowe są bezpłatne", "Szczepienia obowiązkowe dotyczą dzieci, a zalecane – dorosłych"},
                    AnswerIndex = 2,
                    Score = 1
                },

                new QuizItem
                {
                    Question = "Do szczepień obowiązkowych należą:",
                    Choices = new List<string> { "Szczepienia niemowląt przeciw meningokokom grupy B i rotawirusom.", "Szczepienia dzieci przeciw odrze, śwince i różyczce", "Szczepienia przypominające dorosłych przeciw błonicy, tężcowi i krztuścowi", "Szczepienia przeciw wirusowemu zapaleniu wątroby typu B dzieci, młodzieży i dorosłych"},
                    AnswerIndex = 1,
                    Score = 1
                },

                new QuizItem
                {
                    Question = "Szczepienia poekspozycyjne są to szczepienia wykonywane po narażeniu na czynnik zakaźny, (np. po bezpośrednim kontakcie z osobą, która zaraża). Do obowiązkowych szczepień poekspozycyjnych należą:",
                    Choices = new List<string> { "Tylko szczepienia przeciw tężcowi i wściekliźnie", "Szczepienia przeciw odrze i ospie wietrznej", "Szczepienia przeciw błonicy, tężcowi i wściekliźnie", "Tylko szczepienia przeciw wściekliźnie"},
                    AnswerIndex = 2,
                    Score = 1
                },
                new QuizItem
                {
                    Question = "Pierwsza opracowana szczepionka była przeciwko ospie prawdziwej:",
                    Choices = new List<string> {"Prawda", "Fałsz"},
                    AnswerIndex = 0,
                    Score = 1
                },
                new QuizItem
                {
                    Question = "Chorobą, która została całkowicie wyeliminowana z powierzchni ziemi dzięki szczepieniom jest:",
                    Choices = new List<string> {"Dur brzuszny", "Ospa prawdziwa", "Poliomyelitis", "Dźuma"},
                    AnswerIndex = 2,
                    Score = 1
                },
                new QuizItem
                {
                    Question = "Które z poniższych NIE jest chorobą, której można zapobiec dzięki szczepieniu?",
                    Choices = new List<string> {"Rak szyjki macicy", "Odra", "Paraliż dziecięcy", "Astma"},
                    AnswerIndex = 3,
                    Score = 1
                },
                new QuizItem
                {
                    Question = "Krztusiec powrócił, ponieważ:",
                    Choices = new List<string> {"Oryginalna szczepionka nie była skuteczna", "Niewystarczająca liczba rodziców szczepiła swoje dzieci (ruchy antyszczepionkowców)", "Nowy szczep wirusa przybył do Stanów Zjednoczonych z zagranicy w latach siedemdziesiątych XX wieku", "Oryginalna szczepionka została celowo osłabiona"},
                    AnswerIndex = 3,
                    Score = 1
                },
                new QuizItem
                {
                    Question = "Która pandemia wybuchła w 1918 roku?",
                    Choices = new List<string> {"Grypa hiszpanka", "Ebola", "Dżuma", "Świńska grypa"},
                    AnswerIndex = 0,
                    Score = 1
                },
                new QuizItem
                {
                    Question = "Inna nazwa wirusa grypy A/H1N1, który przerodził się w pandemię to:",
                    Choices = new List<string> {"Ptasia grypa", "Świńska grypa", "Grypa hiszpanka", "Wirus HIV"},
                    AnswerIndex = 1,
                    Score = 1
                },
                new QuizItem
                {
                    Question = "Czy wirus dżumy zaliczany jest do broni biologicznej?",
                    Choices = new List<string> {"Tak", "Nie"},
                    AnswerIndex = 0,
                    Score = 1
                },
                new QuizItem
                {
                    Question = "Dorośli potrzebują dawki przypominającej przeciwko tężcowi i błonicy co 10 lat.",
                    Choices = new List<string> {"Prawda", "Fałsz"},
                    AnswerIndex = 0,
                    Score = 1
                },
                new QuizItem
                {
                    Question = "Czy wszystkie 3 dostępne szczepionki na koronawirusa (Pfizer/Moderna/AstraZeneca) to szczepionki mRNA? ",
                    Choices = new List<string> {"Tak", "Nie"},
                    AnswerIndex = 1,
                    Score = 1
                },
                new QuizItem
                {
                    Question = "Czy przyjęcie szczepionki na COVID-19 może wywołać zakażenie koronawirusem?",
                    Choices = new List<string> {"Tak", "Nie"},
                    AnswerIndex = 1,
                    Score = 1
                },
                new QuizItem
                {
                    Question = "Czy szczepionka wykorzystująca mRNA może wpłynąć na materiał genetyczny człowieka?",
                    Choices = new List<string> {"Tak", "Nie"},
                    AnswerIndex = 1,
                    Score = 1
                },
                new QuizItem
                {
                    Question = "Czy szczepienia powodują autyzm?",
                    Choices = new List<string> {"Tak", "Nie"},
                    AnswerIndex = 1,
                    Score = 1
                },
            };

            return new OkObjectResult(Quiz);
        }
    }
}
