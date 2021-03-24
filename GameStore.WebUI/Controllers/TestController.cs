using GameStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.WebUI.Controllers
{
    public class TestController : Controller
    {
        ITestRepository repository;

        public TestController(ITestRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View("Test", repository.Tests);
        }
    }
}