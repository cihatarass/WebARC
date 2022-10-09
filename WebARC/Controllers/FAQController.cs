using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebARC.Controllers
{
    [Authorize(Roles = "Admin")]

    public class FAQController : Controller
    {
        FAQManager fAQManager = new FAQManager(new EfFAQDal());


        [HttpGet]
        public IActionResult Index(int id)
        {
            var values = fAQManager.GetByID(1);
            return View(values);
        }

        public IActionResult Index(FAQ fAQ)
        {
            fAQManager.TUpdate(fAQ);
            TempData["Alert"] = " Kayıt Başarıyla Güncellendi!";
            return RedirectToAction("Index");
        }
    }
}
