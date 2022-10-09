using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebARC.ViewComponents.HeadSlider
{
    public class HeaderList : ViewComponent
    {
        HeadSliderManager headSliderManager = new HeadSliderManager(new EfHeadSliderDal());

        public IViewComponentResult Invoke()
        {
            var values = headSliderManager.TGetList();
            return View(values);
        }
    }
}
