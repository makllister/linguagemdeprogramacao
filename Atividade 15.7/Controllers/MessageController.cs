using Microsoft.AspNetCore.Mvc;
using Atividade15._7.Models;
using System.Collections.Generic;

namespace Atividade15._7.Controllers
{
    public class MessageController : Controller
    {
        private static List<Message> messages = new List<Message>();

        [HttpGet]
        public IActionResult Index()
        {
            return View(messages);
        }

        [HttpPost]
        public IActionResult Index(Message message)
        {
            messages.Add(message);
            return View(messages);
        }
    }
}
