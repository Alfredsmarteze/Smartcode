using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Smartcode.Data;
using Smartcode.Models;

namespace Smartcode.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Smartcodecontext _smartcodecontext;
        private readonly IYourMessage _yourMessage;
        public HomeController(ILogger<HomeController> logger, Smartcodecontext smartcodecontext, IYourMessage yourMessage)
        {
            _logger = logger;
            _smartcodecontext = smartcodecontext;
            _yourMessage = yourMessage;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult _YourMessage()
        {

            YourMessage yourMessage = new YourMessage
            {
                Date = DateTime.Today
            };

            return View(yourMessage);
        }

        [HttpPost]
        public async Task<IActionResult> _YourMessage(YourMessage yourMessage)
        {
            if (ModelState.IsValid)
            {
               await _yourMessage.AddMessage(yourMessage);
                 ViewData["YourMessage"] = "Thank you, your message have gotten to us, we will get back to you shortly.";
                ModelState.Clear();
                RedirectToAction("Index","HomeController");
            }
            return View();
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
