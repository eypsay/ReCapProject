using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    class EfDenemeDal : EfEntityRepositoryBase<Deneme, CarContext>, IDenemeDal
    {
        //public void Add(Deneme entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(Deneme entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Deneme Get(Expression<Func<Deneme, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Deneme> GetAll(Expression<Func<Deneme, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Deneme entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
