using DataAccess.Abstract;
using Core.DataAccess;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product Entity)
        {
            using (NorthwindContext context = new NorthwindContext())//Idisposable Pattern Implematon
            {
                var addetEntity = context.Entry(Entity);
                addetEntity.State = EntityState.Added;
                context.SaveChanges();

            }

        }

        public void Delete(Product Entity)
        {
            using (NorthwindContext context = new NorthwindContext())//Idisposable Pattern Implematon
            {
                var deleteEntity = context.Entry(Entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ?
                    context.Set<Product>().ToList() : 
                    context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product Entity)
        {
            using (NorthwindContext context = new NorthwindContext())//Idisposable Pattern Implematon
            {
                var updateEntity = context.Entry(Entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
