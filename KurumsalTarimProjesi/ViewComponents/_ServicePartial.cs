using BusinessLayer.Abstrack;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTarimProjesi.ViewComponents
{
    public class _ServicePartial : ViewComponent
    {
        private readonly IServiceService _serviceService;

        public _ServicePartial(IServiceService serviceService    )
        {
            _serviceService = serviceService;
        }

        public IViewComponentResult Invoke()
        {
            var vales = _serviceService.GetListAll();
            return View(vales);
        }
    }
}
