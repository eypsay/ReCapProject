using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] ///----> Attribute or Annotaion class ile ilgili bigi  verme yani imzasıdır
    public class CarsController : ControllerBase
    {

        //*****Bir katman diger katmaınn somutu dısında baglantı kuramazassın****
        
        //bu ir gevsek bagllık var yani soyuta baglılgı var
        //Loosely  Coupled

        ICarService _carService;
        //IoC ---Degisimn kontrolu-->Inversion of Control
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        //public  List<Car> Get()
        //{
        //    //burada Dpepndecy Chain var ----> IProdcutService bir ProdectManager a ihitaca dudyor productMangerda EfCarDal ihitiyac duyuyor
        //  //  ICarService carService = new CarManager(new EfCarDal());
        //  //COnstructor Injection yaparak agımlıgı cozecegiz

        //    var result = _carService.GetAll();
        //    return result.Data;

        //} Asagıdaki kodllar ile degistirdik

        public IActionResult GetAll()
        {
            //burada Dpepndecy Chain var ----> IProdcutService bir ProdectManager a ihitaca dudyor productMangerda EfCarDal ihitiyac duyuyor
            //  ICarService carService = new CarManager(new EfCarDal());
            //COnstructor Injection yaparak agımlıgı cozecegiz

            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result); 
            }
            return BadRequest(result);

        }
        [HttpGet("getbyid")]
        public IActionResult GetByID(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


    }
}
