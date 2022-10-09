using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class SocialLinksManager : ISocialLinksService
    {
        ISocialLinksDal _socialLinksDal;

        public SocialLinksManager(ISocialLinksDal socialLinksDal)
        {
            _socialLinksDal = socialLinksDal;
        }

        public SocialLinks GetByID(int id)
        {
            return _socialLinksDal.GetByID(id);
        }

        public void TAdd(SocialLinks t)
        {
            _socialLinksDal.Insert(t);
        }

        public void TDelete(SocialLinks t)
        {
            _socialLinksDal.Delete(t);
        }

        public List<SocialLinks> TGetList()
        {
            return _socialLinksDal.GetList();
        }

        public void TUpdate(SocialLinks t)
        {
            _socialLinksDal.Update(t);
        }
    }
}
