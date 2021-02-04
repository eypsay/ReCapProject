using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{

    class InMemoryColorDal : IColorDal
    {
        /*IEntityRepository interfaceni yazdığımız için
        * asaidaki kodları yenisi olan asaidakilerle
        * degistirdik*/
        //List<Color> _colors;

        //public InMemoryColorDal()
        //{
        //    _colors = new List<Color> {
        //    new Color{ColorId=1,Name="Orange",Description="Shine"},
        //    new Color{ColorId=2,Name="Fuscha",Description="Turkuaz"},
        //    };
        //}


        //public void Add(Color color)
        //{
        //    _colors.Add(color);
        //}

        //public void Delete(Color color)
        //{
        //    _colors.Remove(_colors.SingleOrDefault(c => c.ColorId == color.ColorId));
        //}

        //public List<Color> GetAll()
        //{
        //    return _colors;
        //}

        //public List<Color> GetById(int colorId)
        //{
        //    return _colors.Where(c => c.ColorId == colorId).ToList();
        //}

        //public void Update(Color color)
        //{
        //   Color updateColor= _colors.SingleOrDefault(c => c.ColorId == color.ColorId);

        //   updateColor.Name =  color.Name;
        //    updateColor.Description = color.Description;
        //}
        public void Add(Color entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color entity)
        {
            throw new NotImplementedException();
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
