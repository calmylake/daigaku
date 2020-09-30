using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using chatbot.Models;
using IBM.Cloud.SDK.Core.Authentication.Iam;
using IBM.Watson.Assistant.v2;
using IBM.Watson.Assistant.v2.Model;

namespace chatbot.Controllers
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Mensagem(string sessionId, string message) {
            IamConfig iamConfig = new IamConfig(
                apikey: "yFsCxVoNUmQtCOvr7qAggCyhCggRVhKrzYNc5tUFcEoI"
            );
            var service = new AssistantService("2019-02-28", iamConfig);
            service.SetEndpoint("https://gateway.watsonplatform.net/assistant/api");
            if (string.IsNullOrWhiteSpace(sessionId)) {
                var resultSession = service.CreateSession("2320fc61-8883-4b0d-a4b4-921bc5c13d61");

                sessionId = resultSession.Result.SessionId;
                message = "";
            }

            var result = service.Message("2320fc61-8883-4b0d-a4b4-921bc5c13d61", sessionId, new MessageInput() {
                Text = message
            });

            MessageResponse response = Newtonsoft.Json.JsonConvert.DeserializeObject<MessageResponse>(result.Response);
            return Json(new { sessionId = sessionId, response = response, responseStr = result.Response });
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
