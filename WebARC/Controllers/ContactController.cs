using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebARC.Controllers
{
    [Authorize(Roles = "Admin")]

    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());


        [HttpGet]
        public IActionResult Index()
        {
            var values = contactManager.GetByID(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            ContactValidator rules = new ContactValidator();
            ValidationResult result = rules.Validate(contact);

            if (result.IsValid)
            {
                contactManager.TUpdate(contact);
                TempData["alert"] = "İletişim Bilgileri Başarıyla Düzenlendi";
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return View();
            }


          
        }
    }
}
