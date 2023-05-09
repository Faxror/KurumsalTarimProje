using BusinessLayer.Abstrack;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTarimProjesi.Controllers
{
    public class AnnoncementController : Controller
    {
        private readonly IAnnoncementService _annoncementService;

        public AnnoncementController(IAnnoncementService annoncementService)
        {
            _annoncementService = annoncementService;
        }

        public IActionResult Index()
        {
            var values = _annoncementService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAn(Annoncement p)
        {
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.Status = false;
            _annoncementService.Insert(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddUpdate(int id)
        {
            var value = _annoncementService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult AddUpdate(Annoncement p)
        {
            _annoncementService.Update(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var value = _annoncementService.GetById(id);
            _annoncementService.Delete(value);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatusToTrue(int id)
        {
            _annoncementService.AnnoncementStatusToTrue(id);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatusToFalse(int id)
        {
            _annoncementService.AnnoncementStatusToFalse(id);
            return RedirectToAction("Index");
        }
    }
}
