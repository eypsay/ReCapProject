using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Autofac,Ninject,CastleWindsor, StructreMap,LightInject,DryInject --> IoC Container altyapýs sunar
            //Biz AOP yapacagýz,
            services.AddControllers();
            //*****///BU Codelarý DependecyResolvers/Autofac te yaptýðýmýz için kapattýk
            //services.AddSingleton<ICarService,CarManager>();//bana arakplanda bir refrans olustur. /Icerisnde data tutumuyorsak Singleton kullanýlýr
            ////data olnalarda Add AddScoped, AddTransient kullanýlýr
            //services.AddSingleton<ICarDal, EfCarDal>();

            //services.AddSingleton<IRentalService, RentalManager>();
            //services.AddSingleton<IRentalDal, EfRentalDal>();

            //services.AddSingleton<IBrandService, BrandManager>();
            //services.AddSingleton<IBrandDal, EfBrandDal>();

            //services.AddSingleton<ICustomerDal, EfCustomerDal>();
            //services.AddSingleton<ICustomerService, CustomerManager>();

            //services.AddSingleton<IColorDal, EfColorDal>();
            //services.AddSingleton<IColorService, ColorManager>();

            //services.AddSingleton<IUserDal, EfUserDal>();
            //services.AddSingleton<IUserService, UserManager>();





        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
