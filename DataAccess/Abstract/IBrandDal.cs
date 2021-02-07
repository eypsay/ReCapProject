using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBrandDal:IEntityRepository<Brand>
    {
        /*IEntityRepository interfaceni yazdığımız için
         * asaidaki kodları yenisi olan asaidakilerle
         * degistirdik*/
        //void Add(Brand brand );
        //void Update(Brand brand);
        //void Delete(Brand brand );
        //List<Brand> GetAll();


    }
}
