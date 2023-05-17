using BusinessLayer.Abstrack;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTarimProjesi.Controllers
{
    [AllowAnonymous]

    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var values = _serviceService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service p)
        {
            _serviceService.Insert(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddUpdate(int id)
        {
            var value = _serviceService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult AddUpdate(Service p)
        {
            _serviceService.Update(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var value = _serviceService.GetById(id);
            _serviceService.Delete(value);
            return RedirectToAction("Index");
        }
    }
}
