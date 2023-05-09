using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTarimProjesi.Controllers
{
    public class AdressController : Controller
    {
        private readonly IAdressDal _adressDal;

        public AdressController(IAdressDal adressDal)
        {
            _adressDal = adressDal;
        }

        public IActionResult Index()
        {
            var values = _adressDal.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddUpdate(int id)
        {
            var value = _adressDal.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult AddUpdate(Adress p)
        {
            _adressDal.Update(p);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult UpdataAdres(int id)
        {
            var values = _adressDal.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdataAdres(Adress p)
        {
            _adressDal.Update(p);
             return RedirectToAction("Index");
        }
    }
}
