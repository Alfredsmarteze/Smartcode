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
        public HomeController(ILogger<HomeController> logger, Smartcodecontext smartcodecontext)
        {
            _logger = logger;
            _smartcodecontext = smartcodecontext;
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
                await _smartcodecontext.yourMessage.AddAsync(yourMessage);
              await  _smartcodecontext.SaveChangesAsync();
                ModelState.Clear();
                ViewData["YourMessage"] = "Thank you, your message have gotten to us, we will get back to you shortly.";
                RedirectToAction("Index", "Home");
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
