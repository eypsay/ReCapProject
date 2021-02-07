using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context nesnesi:DB tabloları ile proje classlarını baglamak
    //DbContext: Entityframework ile beraber base bir sınıftır

    public class CarContext :DbContext
    {

        //veritabanımın yeri icin yazdık 
        //OnConfiguring:projem hangi veritabanı ile ilişkili
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);ihtiyacım yok dbcontextin builderini calitirir
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database = ReCapProject;Trusted_Connection=true ");

        }

        //hangi nesnem hangi esneye karşılık gelecek
        //DbSet<Bendeki class> veritabınındaki tablo {get;set;}
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
