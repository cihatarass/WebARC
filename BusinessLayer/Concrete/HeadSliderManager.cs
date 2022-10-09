using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class HeadSliderManager : IHeadSliderService
    {
        IHeadSliderDal _headSliderDal;

        public HeadSliderManager(IHeadSliderDal headSliderDal)
        {
            _headSliderDal = headSliderDal;
        }

        public HeadSlider GetByID(int id)
        {
             return _headSliderDal.GetByID(id);
        }

        public void TAdd(HeadSlider t)
        {
            _headSliderDal.Insert(t);
        }

        public void TDelete(HeadSlider t)
        {
            _headSliderDal.Delete(t);
        }

        public List<HeadSlider> TGetList()
        {
            return _headSliderDal.GetList();
        }

        public void TUpdate(HeadSlider t)
        {
            _headSliderDal.Update(t);
        }
    }
}
