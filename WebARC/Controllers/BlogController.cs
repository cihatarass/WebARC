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

    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogDal());

        public IActionResult Index()
        {
            var values = blogManager.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddBlog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
            BlogValidator rules = new BlogValidator();
            ValidationResult result = rules.Validate(blog);

            if (result.IsValid)
            {
                blogManager.TAdd(blog);
                TempData["Alert"] = " Blog Yazısı Başarıyla Eklendi!";
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();


        }

        public  IActionResult DeleteBlog(int id)
        {
            var values = blogManager.GetByID(id);
            blogManager.TDelete(values);
            TempData["Alert"] = " Blog Yazısı Başarıyla Silindi!";
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateBlog(int id)
        {
            var values = blogManager.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateBlog(Blog blog)
        {
            BlogValidator rules = new BlogValidator();
            ValidationResult result = rules.Validate(blog);

            if (result.IsValid)
            {
                blogManager.TUpdate(blog);
                TempData["Alert"] = " Blog Yazısı Başarıyla Güncellendi!";
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();


        }
    }
}
