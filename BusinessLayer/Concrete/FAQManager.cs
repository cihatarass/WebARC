using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class FAQManager : IFAQService
    {

        IFAQDal _fAQDal;

        public FAQManager(IFAQDal fAQDal)
        {
            _fAQDal = fAQDal;
        }

        public FAQ GetByID(int id)
        {
            return _fAQDal.GetByID(id);
        }

        public void TAdd(FAQ t)
        {
            _fAQDal.Insert(t);
        }

        public void TDelete(FAQ t)
        {
            _fAQDal.Delete(t);
        }

        public List<FAQ> TGetList()
        {
            return _fAQDal.GetList();
        }

        public void TUpdate(FAQ t)
        {
            _fAQDal.Update(t);
        }
    }
}
