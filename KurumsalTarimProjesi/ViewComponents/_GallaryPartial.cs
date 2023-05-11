using BusinessLayer.Abstrack;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTarimProjesi.ViewComponents
{
    public class _GallaryPartial : ViewComponent
    {
        private readonly IImageService _ımageService;

        public _GallaryPartial(IImageService ımageService)
        {
            _ımageService = ımageService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _ımageService.GetListAll();
            return View(values);
        }
    }
}
