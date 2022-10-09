using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebARC.Controllers
{
    [Authorize(Roles = "Admin")]

    public class TeamController : Controller
    {
        TeamManager teamManager = new TeamManager(new EfTeamDal());

        public IActionResult Index()
        {
            var values = teamManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTeam(Team team)
        {
            TeamValidator rules = new TeamValidator();
            ValidationResult result = rules.Validate(team);

            if (result.IsValid)
            {
                teamManager.TAdd(team);
                TempData["Alert"] = " Personel Başarıyla Eklendi!";
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

      
        }


        
        public IActionResult DeleteTeam(int id)
        {
            var values = teamManager.GetByID(id);
            teamManager.TDelete(values);
            TempData["Alert"] = " Personel Başarıyla Silindi!";
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateTeam(int id)
        {
            var values = teamManager.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateTeam(Team team)
        {
            TeamValidator rules = new TeamValidator();
            ValidationResult result = rules.Validate(team);

            if (result.IsValid)
            {
                teamManager.TUpdate(team);
                TempData["Alert"] = " Personel ait Bilgiler Başarıyla Güncellendi!";
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return View();
            }

   
        }

    }
}
