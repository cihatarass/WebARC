using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebARC.ViewComponents.About
{
    public class ReferenceAboutList:ViewComponent
    {
        ReferenceManager ReferenceManager = new ReferenceManager(new EfReferenceDal());

        public IViewComponentResult Invoke()
        {
            var values = ReferenceManager.TGetList();
            return View(values);
        }
    }
}
