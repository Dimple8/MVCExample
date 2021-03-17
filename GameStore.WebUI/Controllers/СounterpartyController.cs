using GameStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.WebUI.Controllers
{
    public class СounterpartyController : Controller
    {
        IСounterpartyRepository repository;

        public СounterpartyController(IСounterpartyRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View("Сounterparty", repository.Сounterpartys);
        }
    }
}