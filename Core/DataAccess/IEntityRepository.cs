
using Core.DataAccess;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
   public  interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null); // parentez icin filtreleme kullanabilmemiz icindir = null ise geri bana deerl getirmesende olur 
        // bu kodu bidaha yazmaycagiz sadae expression yazmak ici kulancagiz
        T Get(Expression<Func<T, bool>> filter);

        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
    }
}
