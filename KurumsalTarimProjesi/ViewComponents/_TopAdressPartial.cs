using BusinessLayer.Abstrack;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTarimProjesi.ViewComponents
{
    public class _TopAdressPartial : ViewComponent
    {
        private readonly IAdressService _adressService;

        public _TopAdressPartial(IAdressService adressService)
        {
            _adressService = adressService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _adressService.GetListAll();
            return View(values);
        }
    }
}
