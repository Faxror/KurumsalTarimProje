﻿using BusinessLayer.Abstrack;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTarimProjesi.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IActionResult Index()
        {
            var values = _adminService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAdmin(Admin p)
        {
            _adminService.Insert(p);
                return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddUpdate(int id)
        {
            var value = _adminService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult AddUpdate(Admin p)
        {
            _adminService.Update(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAdmin(int id)
        {
            var value = _adminService.GetById(id);
            _adminService.Delete(value);
            return RedirectToAction("Index");
        }
    }
}
