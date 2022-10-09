using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class OurServiceManager : IOurServiceService
    {
        IOurServiceDal _ourServiceDal;

        public OurServiceManager(IOurServiceDal ourServiceDal)
        {
            _ourServiceDal = ourServiceDal;
        }

        public OurService GetByID(int id)
        {
            return _ourServiceDal.GetByID(id);
        }

        public void TAdd(OurService t)
        {
            _ourServiceDal.Insert(t);
        }

        public void TDelete(OurService t)
        {
            _ourServiceDal.Delete(t);
        }

        public List<OurService> TGetList()
        {
            return _ourServiceDal.GetList();
        }

        public void TUpdate(OurService t)
        {
            _ourServiceDal.Update(t);
        }
    }
}
