using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebARC.ViewComponents.OurService
{
    public class OurServiceList:ViewComponent
    {
        OurServiceManager ourServiceManager = new OurServiceManager(new EfOurServiceDal());

        public IViewComponentResult Invoke()
        {
            var values = ourServiceManager.TGetList();
            return View(values);
        }
    }
}
