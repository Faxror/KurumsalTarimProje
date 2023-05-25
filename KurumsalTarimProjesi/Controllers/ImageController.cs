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
    public class ImageController : Controller
    {
        private readonly IImageDal _ımageDal;

        public ImageController(IImageDal ımageDal)
        {
            _ımageDal = ımageDal;
        }

        public IActionResult Index()
        {
            var values = _ımageDal.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddImage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddImage(Image p)
        {
            ImageValidator validationrules = new ImageValidator();
            ValidationResult result = validationrules.Validate(p);
            if (result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            _ımageDal.Insert(p);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult AddUpdate(int id)
        {
            var value = _ımageDal.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult AddUpdate(Image p)
        {
            _ımageDal.Update(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteImage(int id)
        {
            var value = _ımageDal.GetById(id);
            _ımageDal.Delete(value);
            return RedirectToAction("Index");
        }
    }
}
