using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebARC.ViewComponents.Product
{
    public class ProductList : ViewComponent
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        public IViewComponentResult Invoke()
        {
            var values = productManager.TGetList();
            return View(values);
        }
    }
}
