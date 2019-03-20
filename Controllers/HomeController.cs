using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using mvc1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace mvc1.Controllers {
    public class HomeController : Controller {
        private readonly IRepository _repository;
        private readonly string message;

        public HomeController (IRepository repository, IConfiguration config) {
            _repository = repository;
            message = config["MESSAGE"] ?? $"ASP NET CORE MVC - DOCKER - {config["HOSTNAME"]}";
        }

        public IActionResult Index () {
            ViewBag.Message = message;
            return View (_repository.Produtos);
        }
    }
}