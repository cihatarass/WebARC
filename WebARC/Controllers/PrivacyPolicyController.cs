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

    public class PrivacyPolicyController : Controller
    {
        PrivacyPolicyManager policyManager = new PrivacyPolicyManager(new EfPrivacyPolicyDal());

        [HttpGet]
        public IActionResult Index()
        {
            var values = policyManager.GetByID(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(PrivacyPolicy policy)
        {
            policyManager.TUpdate(policy);
            TempData["Alert"] = " Kayıt Başarıyla Güncellendi!";
            return RedirectToAction("Index");
        }
    }
}
