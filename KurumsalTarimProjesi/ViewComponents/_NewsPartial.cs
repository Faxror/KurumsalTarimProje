using BusinessLayer.Abstrack;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTarimProjesi.ViewComponents
{
    public class _NewsPartial : ViewComponent
    {
        private readonly IAnnoncementService _annoncementService;

        public _NewsPartial(IAnnoncementService annoncementService)
        {
            _annoncementService = annoncementService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _annoncementService.GetListAll();
            return View(values);
        }
    }
}
