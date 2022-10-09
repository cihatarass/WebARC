using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebARC.ViewComponents.Dashboard
{
    public class BlogStatistics: ViewComponent
    {

        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            
            ViewBag.v1 = c.Products.Count();
            ViewBag.v2 = c.ourServices.Count();
            ViewBag.v3 = c.References.Count();
            ViewBag.v4 = c.Blogs.Count();

            return View();
        }
    }
}
