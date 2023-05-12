using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using KurumsalTarimProjesi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTarimProjesi.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
    
        private readonly UserManager<IdentityUser> _userManager;

        public RegisterController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel model)
        {

            IdentityUser ıdentityuser = new IdentityUser()
            {
                Id = "1",
                UserName = model.Username,
                Email = model.Email

            };
            if (model.Password == model.confrimpassword)
            {
                var result = await _userManager.CreateAsync(ıdentityuser, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }
            return View(model);

        
        }
        
        }
}
