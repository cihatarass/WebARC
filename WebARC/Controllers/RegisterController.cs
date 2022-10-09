using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebARC.Models;

namespace WebARC.Controllers
{
    [Authorize(Roles = "Admin")]

    public class RegisterController : Controller
    {
        private readonly UserManager<AdministratorUser> _userManager;

        public RegisterController(UserManager<AdministratorUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AdministratorAddViewModel administrator)
        {
        
                AdministratorUser user = new AdministratorUser()
                {
                    Name = administrator.Name,
                    Surname = administrator.SurName,
                    Email = administrator.Mail,
                    UserName = administrator.UserName,

                };


                if (administrator.ConfirmPassword == administrator.Password)
                {
                
                var result = await _userManager.CreateAsync(user, administrator.Password);
               
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

                }


            return View();
        }
    }
}
