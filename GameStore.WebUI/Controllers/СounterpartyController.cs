using GameStore.Domain.Abstract;
using System.Linq;
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

        public ViewResult Edit(int id_counterparty)
        {
            Сounterparty counterparty = repository.Сounterpartys
                .FirstOrDefault(c => c.id_counterparty == id_counterparty);
            return View(counterparty);
        }

        // Перегруженная версия Edit() для сохранения изменений
        [HttpPost]
        public ActionResult Edit(Сounterparty counterparty)
        {
            if (ModelState.IsValid)
            {
                repository.SaveСounterparty(counterparty);
                TempData["message"] = string.Format("Контрагент \"{0}\" сохранен", counterparty.name);
                return RedirectToAction("Index");
            }
            else
            {
                // Что-то не так со значениями данных
                return View(counterparty);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new Сounterparty());
        }

        [HttpPost]
        public ActionResult Delete(int id_counterparty)
        {
            Сounterparty deletedСounterparty = repository.DeleteСounterparty(id_counterparty);
            if (deletedСounterparty != null)
            {
                TempData["message"] = string.Format("Контрагент \"{0}\" был удален",
                    deletedСounterparty.name);
            }
            return RedirectToAction("Index");
        }        

        //[HttpPost]
        //public ActionResult Save(Сounterparty counterparty)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        repository.SaveСounterparty(counterparty);
        //    }

        //    return RedirectToAction("Index");
        //}
    }
}