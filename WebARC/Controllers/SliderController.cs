using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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

    public class SliderController : Controller
    {

        HeadSliderManager headSliderManager = new HeadSliderManager(new EfHeadSliderDal());

        public IActionResult Index()
        {
            var values = headSliderManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSlider()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSlider(SliderImageViewModel slider)
        {
            HeadSlider p = new HeadSlider();
            if (slider.Image != null)
            {
                var extension = Path.GetExtension(slider.Image.FileName);
                var newimgname = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newimgname);
                var stream = new FileStream(location, FileMode.Create);
                slider.Image.CopyTo(stream);
                p.Image = newimgname;
            }

            p.Title = slider.Title;
            p.SubTitle = slider.SubTitle;
            p.Text = slider.Text;
            TempData["Alert"] = "Ürün Başarıyla Eklendi!";
            headSliderManager.TAdd(p);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteSlider(int id)
        {
            var values = headSliderManager.GetByID(id);
            headSliderManager.TDelete(values);
            TempData["Alert"] = " Kayıt Başarıyla Silindi!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSlider(int id)
        {
            var values = headSliderManager.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSlider(HeadSlider headSlider)
        {
            headSliderManager.TUpdate(headSlider);
            TempData["Alert"] = " Kayıt Başarıyla Güncellendi!";
            return RedirectToAction("Index");
        }
    }
}
