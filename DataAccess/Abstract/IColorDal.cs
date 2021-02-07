using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;

using System.Text;

namespace DataAccess.Abstract
{
   public interface IColorDal:IEntityRepository<Color>
    {
        /*IEntityRepository interfaceni yazdığımız için
         * asaidaki kodları yenisi olan asaidakilerle
         * degistirdik*/
        //List<Color> GetAll();
        //void Add(Color color);
        //void Update(Color color );
        //void Delete(Color color );
        //List<Color> GetById(int colorId);
    }
}
