using BusinessLayer.Abstrack;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTarimProjesi.ViewComponents
{
    public class _SocailMediaPartial : ViewComponent
    {
        private readonly ISocialMediaService _socailMediaService;

        public _SocailMediaPartial(ISocialMediaService socailMediaService)
        {
            _socailMediaService = socailMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _socailMediaService.GetListAll();
            return View(values);
        }
    }
}
