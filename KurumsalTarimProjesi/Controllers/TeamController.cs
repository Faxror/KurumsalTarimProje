using BusinessLayer.Abstrack;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTarimProjesi.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            var values = _teamService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTeam(Team s)
        {
            _teamService.Insert(s);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTeam(int id)
        {
            var values = _teamService.GetById(id);
            _teamService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddUpdate(int id)
        {
            var values = _teamService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult AddUpdate(Team g)
        {
            _teamService.Update(g);
            return RedirectToAction("Index");
        }
    }
}
