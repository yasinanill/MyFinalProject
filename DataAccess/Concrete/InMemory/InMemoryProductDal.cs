using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
   public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
               new Product {ProductId=1,CategoryId=1,ProductName="NArdak",UnitsInStock= 10,UnitPrice=10},
            new Product { ProductId = 2, CategoryId = 2, ProductName = "Mouse", UnitsInStock = 2, UnitPrice = 100 },
            new Product { ProductId = 3, CategoryId = 3, ProductName = "Klavye", UnitsInStock = 3, UnitPrice = 1000 },
            new Product { ProductId = 4, CategoryId = 4, ProductName = "Kulaklik", UnitsInStock = 65, UnitPrice = 500 },
            new Product { ProductId = 5, CategoryId = 5, ProductName = "Kamera", UnitsInStock = 1, UnitPrice = 2000 },


               };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product proDelete = _products.Find(p => p.ProductId == product.ProductId);
            _products.Remove(proDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product proUpdate = _products.Find(p => p.ProductId == product.ProductId);
            proUpdate.ProductName = product.ProductName;
            proUpdate.CategoryId = product.CategoryId;
            proUpdate.UnitsInStock = product.UnitsInStock;
            proUpdate.UnitPrice = product.UnitPrice;






        }
    }
}
