using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebARC.ViewComponents.Social
{
    public class SocialNavbar:ViewComponent
    {
        SocialLinksManager socialLinksManager = new SocialLinksManager(new EfSocialLinksDal());

        public IViewComponentResult Invoke()
        {
           var values = socialLinksManager.TGetList();
            return View(values);
        }
    }
}
