using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebARC.ViewComponents.Blog
{
    public class BlogList:ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogDal());

        public IViewComponentResult Invoke()
        {
            var values = blogManager.TGetList();
            return View(values);
        }
    }
}
