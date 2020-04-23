using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    [Route("Say")]
    public class MessagesController : Controller
    {
        [Route("{**message}")]
        public IActionResult ShowMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                ViewData["Message"] = "empty message";
            }
            else
            {
                ViewData["Message"] = message;
            }

            return View();
        }
    }
}