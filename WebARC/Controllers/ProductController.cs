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

    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());


        public IActionResult Index()
        {
            var values = productManager.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddProduct(ProductImageViewModel product)
        {
            Product p = new Product();
            if (product.Image != null)
            {
                var extension = Path.GetExtension(product.Image.FileName);
                var newimgname = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newimgname);
                var stream = new FileStream(location, FileMode.Create);
                product.Image.CopyTo(stream);
                p.Image = newimgname;
            }

            p.Brand = product.Brand;
            p.Feature = product.Feature;
            p.Title = product.Title;
            p.Text = product.Text;
            p.SubBrand = product.SubBrand;
            p.Stock = product.Stock;
            p.Seo_Keywords = product.Seo_Keywords;
            p.Seo_Description = product.Seo_Description;
            TempData["Alert"] = "Ürün Başarıyla Eklendi!";
            productManager.TAdd(p);
            
            return RedirectToAction("Index");
                
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = productManager.GetByID(id);
            ProductImageViewModel model = new ProductImageViewModel();
            model.Brand = values.Brand;
            model.Title = values.Title;
            model.SubBrand = values.SubBrand;
            model.Text = values.Text;
            model.Stock = values.Stock;
            model.Feature = values.Feature;
            model.Seo_Description = values.Seo_Description;
            model.Seo_Keywords = values.Seo_Keywords;
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateProduct(int  id, ProductImageViewModel productImage)
        {
            var values =  productManager.GetByID(id);
            if (productImage.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(productImage.Image.FileName);
                var imgname = Guid.NewGuid() + extension;
                var saveloc = resource + "/wwwroot/images/" + imgname;
                var stream = new FileStream(saveloc, FileMode.Create);

                productImage.Image.CopyTo(stream);
                values.Image = imgname;
               
            }

            values.Brand = productImage.Brand;
            values.Title = productImage.Title;
            values.SubBrand = productImage.SubBrand;
            values.Text = productImage.Text;
            values.Stock = productImage.Stock;
            values.Feature = productImage.Feature;
            values.Seo_Description = productImage.Seo_Description;
            values.Seo_Keywords = productImage.Seo_Keywords;

            productManager.TUpdate(values);

            return RedirectToAction("Index");

        }

        public IActionResult DeleteProduct(int id)
        {
            var values = productManager.GetByID(id);
            productManager.TDelete(values);
            TempData["Alert"] = "Kayıt Başarıyla Silindi!";
            return RedirectToAction("Index");
        }

  

    }
}
