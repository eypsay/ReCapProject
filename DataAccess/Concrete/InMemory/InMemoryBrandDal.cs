using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        /*IEntityRepository interfaceni yazdığımız için
        * asaidaki kodları yenisi olan asaidakilerle
        * degistirdik*/
        //List<Brand> _brands;

        //public InMemoryBrandDal()
        //{
        //    _brands = new List<Brand> { 
        //    new Brand{BrandId=1,Name="Mercedes",Adress="Berlin"},
        //    new Brand{BrandId=2,Name="BMW",Adress="Frankfurt"},
        //    new Brand{BrandId=3,Name="Renault",Adress="Paris"},
        //    new Brand{BrandId=4,Name="Ferrrari",Adress="Milano"},
        //    };
        //}

        //public void Add(Brand brand )
        //{
        //    _brands.Add(brand); 
        //}

        //public void Delete(Brand brand )
        //{
        //    _brands.Remove(_brands.SingleOrDefault(b => b.BrandId == brand.BrandId));
        //}

        //public List<Brand> GetAll()
        //{
        //    return _brands;
        //}

        //public void Update(Brand brand )
        //{
        //   Brand brandToUpdate= _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
        //    brandToUpdate.Name = brand.Name;
        //    brandToUpdate.Adress = brand.Adress;
        //}
        public void Add(Brand entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand entity)
        {
            throw new NotImplementedException();
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
