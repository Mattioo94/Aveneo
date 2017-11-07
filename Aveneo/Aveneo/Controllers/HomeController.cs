using Aveneo.Models;
using Aveneo.Services.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Aveneo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }

        [HttpGet("api/Companies/{number}")]
        public JsonResult GetCompany(string number)
        {
            _repository.SaveRequest(Request.Headers, number);

            Company company = _repository.FindCompany(number);
            return Json(company);
        }
    }
}
