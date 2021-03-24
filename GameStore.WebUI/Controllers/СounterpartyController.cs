using GameStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameStore.Domain.Entities;


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
            return View(repository.Сounterpartys);
        }
        [HttpPost]
        public ActionResult Edit(Сounterpartys counterparty)
        {
            if (ModelState.IsValid)
            {
                repository.SaveСounterpartys(counterparty);
                TempData["message"] = string.Format("Изменения в игре \"{0}\" были сохранены", counterparty.name);
                return RedirectToAction("Index");
            }
            else
            {
                // Что-то не так со значениями данных
                return View(counterparty);
            }
        }
        public ViewResult Edit()
        {
            return View("Edit");
        }

        public ViewResult Create()
        {
            return View("Create", new Сounterpartys());
        }

        [HttpPost]
        public ActionResult Delete(int id_counterparty)
        {
            Сounterpartys deletedСounterparty = repository.DeleteСounterpartys(id_counterparty);
            if (deletedСounterparty != null)
            {
                TempData["message"] = string.Format("Игра \"{0}\" была удалена",
                    deletedСounterparty.name);
            }
            return RedirectToAction("Index");
        }
    }
}