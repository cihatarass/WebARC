using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace WebARC.Controllers
{
    [Authorize(Roles = "Admin")]

    public class DashboardController : Controller
    {
        
        private readonly UserManager<AdministratorUser> _userManager;

        public DashboardController(UserManager<AdministratorUser> userManager)
        {
            _userManager = userManager; 
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.NameIdentity = values.Name + " " + values.Surname;

            string api = "14ad2aba611dbef9c504b82a127794c5";
            string conection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(conection);
         

            //Hava Durumu Api 

            ViewBag.WeatherC = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            ViewBag.WeatherText = document.Descendants("clouds").ElementAt(0).Attribute("name").Value;
            ViewBag.WeatherFeels = document.Descendants("feels_like").ElementAt(0).Attribute("value").Value;
            ViewBag.WeatherCity = document.Descendants("city").ElementAt(0).Attribute("name").Value;

        
            return View();
        }

    }
}
