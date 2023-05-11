using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTarimProjesi.ViewComponents
{
    public class _MapPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AgContext agContext = new AgContext();
            var values = agContext.Adresses.Select(x => x.Mapİnfo).FirstOrDefault();

            ViewBag.v = values;
            return View();
        }
    }
}
