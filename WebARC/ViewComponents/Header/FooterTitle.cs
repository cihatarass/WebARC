using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebARC.ViewComponents.Header
{
    public class FooterTitle:ViewComponent
    {
        SettingsManager settingsManager = new SettingsManager(new EfSettingsDal());

        public IViewComponentResult Invoke()
        {
            var values = settingsManager.TGetList();
            return View(values);
        }
    }
}
