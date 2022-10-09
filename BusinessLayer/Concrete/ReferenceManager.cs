using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class ReferenceManager : IReferenceService
    {
        IReferenceDal _ReferenceDal;

        public ReferenceManager(IReferenceDal referenceDal)
        {
            _ReferenceDal = referenceDal;
        }

        public Reference GetByID(int id)
        {
            return _ReferenceDal.GetByID(id);
        }

        public void TAdd(Reference t)
        {
            _ReferenceDal.Insert(t);
        }

        public void TDelete(Reference t)
        {
            _ReferenceDal.Delete(t);
        }

        public List<Reference> TGetList()
        {
            return _ReferenceDal.GetList();
        }

        public void TUpdate(Reference t)
        {
            _ReferenceDal.Update(t);
        }
    }
}
