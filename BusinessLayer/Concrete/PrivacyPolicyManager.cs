using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class PrivacyPolicyManager : IPrivacyPolicyService
    {
        IPrivacyPolicyDal _privacyPolicyDal;

        public PrivacyPolicyManager(IPrivacyPolicyDal privacyPolicyDal)
        {
            _privacyPolicyDal = privacyPolicyDal;
        }

        public PrivacyPolicy GetByID(int id)
        {
            return _privacyPolicyDal.GetByID(id);
        }

        public void TAdd(PrivacyPolicy t)
        {
            _privacyPolicyDal.Insert(t);
        }

        public void TDelete(PrivacyPolicy t)
        {
            _privacyPolicyDal.Delete(t);
        }

        public List<PrivacyPolicy> TGetList()
        {
            return _privacyPolicyDal.GetList();
        }

        public void TUpdate(PrivacyPolicy t)
        {
            _privacyPolicyDal.Update(t);
        }
    }
}
