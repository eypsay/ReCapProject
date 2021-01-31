using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;

        public InMemoryBrandDal()
        {
            _brands = new List<Brand> { 
            new Brand{BrandId=1,BrandName="Mercedes",BrandAdress="Berlin"},
            new Brand{BrandId=2,BrandName="BMW",BrandAdress="Frankfurt"},
            new Brand{BrandId=3,BrandName="Renault",BrandAdress="Paris"},
            new Brand{BrandId=4,BrandName="Ferrrari",BrandAdress="Milano"},
            };
        }

        public void Add(Brand brand )
        {
            _brands.Add(brand); 
        }

        public void Delete(Brand brand )
        {
            _brands.Remove(_brands.SingleOrDefault(b => b.BrandId == brand.BrandId));
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public void Update(Brand brand )
        {
           Brand brandToUpdate= _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
            brandToUpdate.BrandName = brand.BrandName;
            brandToUpdate.BrandAdress = brand.BrandAdress;
        }
    }
}
