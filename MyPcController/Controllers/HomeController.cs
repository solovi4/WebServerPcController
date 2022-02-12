using Microsoft.AspNetCore.Mvc;
using MyPcController.Models;
using MyPcController.Services;
using System.Diagnostics;

namespace MyPcController.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CommandHandler _commandHandler;

        public HomeController(ILogger<HomeController> logger, CommandHandler commandHandler)
        {
            _logger = logger;
            _commandHandler = commandHandler;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult State()
        {
            _logger.LogInformation("State");
            return Json(new { value = false });
        }



        [HttpGet]
        public IActionResult DoIt(Command command)
        {
            _commandHandler.Handle(command);
            return Ok();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}