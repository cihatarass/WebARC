using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebARC.Models;

namespace WebARC.Controllers
{
    [Authorize(Roles = "Admin")]


    public class OurServicesController : Controller
    {
        OurServiceManager ourServiceManager = new OurServiceManager(new EfOurServiceDal());

        public IActionResult Index()
        {
            var values = ourServiceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddOurService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOurService(OurServiceImageViewModel ourService)
        {

            OurService p = new OurService();
            if (ourService.Image != null)
            {
                var extension = Path.GetExtension(ourService.Image.FileName);
                var newimgname = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newimgname);
                var stream = new FileStream(location, FileMode.Create);
                ourService.Image.CopyTo(stream);
                p.Image = newimgname;
            }

            p.Title = ourService.Title;
            p.Text = ourService.Text;
            p.Seo_Description = ourService.Seo_Description;
            p.Seo_Keywords = ourService.Seo_Keywords;
            TempData["Alert"] = "Ürün Başarıyla Eklendi!";
            ourServiceManager.TAdd(p);

            return RedirectToAction("Index");


        }

        public IActionResult DeleteOurService(int id)
        {
            var values = ourServiceManager.GetByID(id);
            ourServiceManager.TDelete(values);
            TempData["Alert"] = " Kayıt Başarıyla Silindi!";
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateOurService(int id)
        {
            var values = ourServiceManager.GetByID(id);
            OurServiceImageViewModel model = new OurServiceImageViewModel();
            model.Text = values.Text;
            model.Title = values.Title;
            model.Seo_Description = values.Seo_Description;
            model.Seo_Keywords = values.Seo_Keywords;
            return View(model);
        }

        [HttpPost]
        public  IActionResult UpdateOurService(int id, OurServiceImageViewModel ourServiceImage)
        {
            var values = ourServiceManager.GetByID(id);
            if (ourServiceImage.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(ourServiceImage.Image.FileName);
                var imgname = Guid.NewGuid() + extension;
                var saveloc = resource + "/wwwroot/images/" + imgname;
                var stream = new FileStream(saveloc, FileMode.Create);

                ourServiceImage.Image.CopyTo(stream);
                values.Image = imgname;
            }

            values.Title = ourServiceImage.Title;
            values.Text = ourServiceImage.Text;
            values.Seo_Keywords = ourServiceImage.Seo_Keywords;
            values.Seo_Description = ourServiceImage.Seo_Description;

            ourServiceManager.TUpdate(values);

            return RedirectToAction("Index");
        }
    }
}
