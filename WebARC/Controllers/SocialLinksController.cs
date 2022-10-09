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

    public class SocialLinksController : Controller
    {
        SocialLinksManager social = new SocialLinksManager(new EfSocialLinksDal());

        [HttpGet]
        public IActionResult Index()
        {
            var values = social.GetByID(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(SocialLinks links)
        {
            social.TUpdate(links);
            TempData["Alert"] = " Kayıt Başarıyla Güncellendi!";
            return RedirectToAction("Index");
        }
    }
}
