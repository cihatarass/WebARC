using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using WebARC.Models;
using WebARC.Helper;

namespace WebARC.Controllers
{
    [AllowAnonymous]

    public class MainController : Controller
    {
        [Route("")]
        [Route("Anasayfa")]
        public IActionResult Index()
        {
           
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavMenuPartial()
        {
            return PartialView();
        }

        
        public PartialViewResult FooterPartial()
        {
            
            return PartialView();
        }

        //Main Pages

        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        [Route("Hakkimizda")]
        public IActionResult AboutPage()
        {
            var values = aboutManager.TGetList();
            return View(values);
        }

        [Route("Urunler")]
        public IActionResult ProductPage()
        {
            return View();
        }

        ProductManager productManager = new ProductManager(new EfProductDal());

        [HttpGet]
        [Route("Urunler/{baslik}-{id:int}")]
        public IActionResult ProductDetails(int id)
        {
           
           Product product = productManager.GetByID(id);
            ViewBag.PMetaDes = product.Seo_Description;
            ViewBag.PMetaKey = product.Seo_Keywords;
            ViewBag.PMetaTitle = product.Title;
            return View(product);
        }

        public IActionResult OurServicePage()
        {
            return View();
        }

        [HttpGet]
        [Route("iletisim")]
        public IActionResult ContactPage()
        {
            return View();
        }

        [HttpPost]
        [Route("iletisim")]
        public IActionResult ContactPage(MailSendViewModel mailSend)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add("info@pasifikdenizinsaat.com");
            mail.From = new MailAddress("noreply@pasifikdenizinsaat.com");
            mail.Subject = "Web Sitesi Üzerinden Teklif İsteği : " + mailSend.Subject;
            mail.Body = "<b> Sayın Yetkili, </b> " + "</br>" + mailSend.Name + " Kişisinden/Firmasından gelen mesajın içeriği aşağıdaki gibidir. </br> " + "<hr />" + mailSend.Message + "</br> <b> İletişime geçilecek kişinin / firmanın iletişim bilgileri aşağıdaki gibidir; </b> " + "</br>" + "<hr />" + "Mail Adresi : " + mailSend.EmailAddress + "</br>" + "Telefon Numarası : " + mailSend.Telephone;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("noreply@pasifikdenizinsaat.com", "Korhan1971++");
            smtp.Port = 587;
            smtp.Host = "mail.pasifikdenizinsaat.com";
            smtp.EnableSsl = false;

            try
            {
                smtp.Send(mail);
                TempData["msg"] = "Mesajınız Gönderilmiştir! Girdiğiniz Bilgilerin Doğru Olması Halinde Sizinle En Kısa Zamanda İletişime Geçilecektir.";
            }
            catch (Exception)
            {

                TempData["msg"] = "Mesajınız Gönderilemedi!!";
            }


            return RedirectToAction("ContactPage", "Main");
        }


        [HttpGet]
        [Route("TeklifVer")]
        public IActionResult GetOffer()
        {
            return View();
        }

        [HttpPost]
        [Route("TeklifVer")]
        public IActionResult GetOffer(MailSendViewModel mailSend)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add("info@pasifikdenizinsaat.com");
            mail.From = new MailAddress("noreply@pasifikdenizinsaat.com");
            mail.Subject = "Web Sitesi Üzerinden Teklif İsteği : " + mailSend.Subject;
            mail.Body = "<b> Sayın Yetkili, </b> " + "</br>" + mailSend.Name + " Kişisinden/Firmasından gelen mesajın içeriği aşağıdaki gibidir. </br> " + "<hr />" + mailSend.Message + "</br> <b> İletişime geçilecek kişinin / firmanın iletişim bilgileri aşağıdaki gibidir; </b> " + "</br>" + "<hr />" + "Mail Adresi : " + mailSend.EmailAddress + "</br>" + "Telefon Numarası : " + mailSend.Telephone;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("noreply@pasifikdenizinsaat.com", "Korhan1971++");
            smtp.Port = 587;
            smtp.Host = "mail.pasifikdenizinsaat.com";
            smtp.EnableSsl = false;

            try
            {
                smtp.Send(mail);
                TempData["msg"] = "Mesajınız Gönderilmiştir! Girdiğiniz Bilgilerin Doğru Olması Halinde Sizinle En Kısa Zamanda İletişime Geçilecektir.";
            }
            catch (Exception)
            {

                TempData["msg"] = "Mesajınız Gönderilemedi!!";
            }


            return RedirectToAction("GetOffer","Main");
        }
    }

}
