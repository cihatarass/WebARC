using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product GetByID(int id)
        {
            return _productDal.GetByID(id);
        }

        public void TAdd(Product t)
        {
            _productDal.Insert(t);
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
