using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //GENENERIC CONSTRAINT
    //kısıttaki class demek, referans tip olabilir anlamındadır 
    //IEntity : IEntity olabilir veya IEntity implemente bir nesne olabilir
    //new(): new lenebilir olmalı
    public interface IEntityRepository<T>where T :class,IEntity,new ()
    {
        //List<T> GetAll();//bunun yerine asagidaki expression yazdık
        // List<T> GetById(int entityId);//bunun yerine asagidaki GET() filter lı methodu yazdik
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);      

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T,bool>> filter );//filtre yazabilmek icin tanimladik

    }
}
