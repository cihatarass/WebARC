using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebARC.ViewComponents.Reference
{
    public class ReferenceList:ViewComponent
    {
        ReferenceManager referenceManager = new ReferenceManager(new EfReferenceDal());

        public IViewComponentResult Invoke()
        {
            var values = referenceManager.TGetList();
            return View(values);
        }
    }
}
