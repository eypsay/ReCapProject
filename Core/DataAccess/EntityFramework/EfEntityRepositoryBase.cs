using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
   public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity:class,IEntity,new()
       where TContext:DbContext,new()       
    {
        public void Add(TEntity entity)
        {
            //Bu codları refactor edeceğiz
            //bu using nesneyi oluştur ve using bitince anında bellekten kaldır   
            //IDisposable pattern implementation of C# bu yapu C# özgüdür
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);//benim gönderdiğim entityle eşleştir yani refaransı yakalama işlemi
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);//benim gönderdiğim entityle eşleştir yani refaransı yakalama işlemi
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {//burası tek data getirir
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {//Expression<Func<Car, bool>> : bu gelecek olan lamda dir
            using (TContext context = new TContext())
            {
                //select * from car =  context.Set<Car>() ve bunun sonucunu listeye cevir
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                try
                {
                    var updatedEntity = context.Entry(entity);//benim gönderdiğim entityle eşleştir yani refaransı yakalama işlemi
                    updatedEntity.State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception e)
                {

                    Console.WriteLine("There is no Car Id. Update CANCELLED:");
                }

            }
        }
    }
}
