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

    public class ReferenceController : Controller
    {
        ReferenceManager referenceManager = new ReferenceManager(new EfReferenceDal());

        public IActionResult Index()
        {
            var values = referenceManager.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddReference()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddReference(ReferenceImageViewModel referenceImage)
        {
            Reference p = new Reference();

            if (referenceImage.Image != null)
            {
                var extension = Path.GetExtension(referenceImage.Image.FileName);
                var newimg = Guid.NewGuid() + extension;
                var loc = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newimg);
                var stream = new FileStream(loc, FileMode.Create);
                referenceImage.Image.CopyTo(stream);
                p.Image = newimg;

            }

            p.Project = referenceImage.Project;
            p.PersonName = referenceImage.PersonName;
            p.CompanyName = referenceImage.CompanyName;
            p.Comment = referenceImage.Comment;

            TempData["Alert"] = "Ürün Başarıyla Eklendi!";
            referenceManager.TAdd(p);

            return RedirectToAction("Index");


        }

        public IActionResult DeleteReference(int id)
        {
            var values = referenceManager.GetByID(id);
            referenceManager.TDelete(values);
            TempData["Alert"] = " Kayıt Başarıyla Silindi!";
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateReference(int id)
        {
            var values = referenceManager.GetByID(id);
            ReferenceImageViewModel model = new ReferenceImageViewModel();
            model.Project = values.Project;
            model.PersonName = values.PersonName;
            model.CompanyName = values.CompanyName;
            model.Comment = values.Comment;
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateReference(int id, ReferenceImageViewModel referenceImage)
        {

            var values = referenceManager.GetByID(id);
            if (referenceImage.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(referenceImage.Image.FileName);
                var imgname = Guid.NewGuid() + extension;
                var saveloc = resource + "/wwwroot/images/" + imgname;
                var stream = new FileStream(saveloc, FileMode.Create);

                referenceImage.Image.CopyTo(stream);
                values.Image = imgname;

            }

            values.Project = referenceImage.Project;
            values.PersonName = referenceImage.PersonName;
            values.CompanyName = referenceImage.CompanyName;
            values.Comment = referenceImage.Comment;
   

            referenceManager.TUpdate(values);

            return RedirectToAction("Index");

        }
    }
}
