using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());

            byte choose = 0;


            do
            {
               
                showMenu();
                choose = (byte)UInt16.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.Clear();
                        getAllCar(carManager);
                        break;
                    case 2:
                        Console.Clear();
                        addNewCar(carManager);
                        break;
                    case 3:
                        Console.Clear();
                        updateCarInfo(carManager);
                        break;
                    case 4:
                        Console.Clear();
                        deleteCar(carManager); break;
                     case 5:
                        Console.Clear();
                        getAllBrand(brandManager);break;
                    case 6:
                        Console.Clear();
                        addNewBrand(brandManager);break;
                    case 7:
                        Console.Clear();
                        updateBrandInfo(brandManager);break;
                    case 8:
                        Console.Clear();
                        deleteBrand(brandManager);break;

                            
                    case 0: break;
                    default: Console.WriteLine("Wrong Chooice"); break;
                }
            } while (choose != 0);

            {

            }
        }
        static void showMenu()
        {

            Console.WriteLine("1-Show All CARS\n" +
                "2-Add a New Car\n" +
                "3-Updade Car's info\n" +
                "4-Delete a Car\n" +
                "5-Show All BRANDS\n" +
                "6-Add a New Brand\n" +
                "7-Update Brand's Info\n" +
                "8-Delete Brand'\n" +
                "0-Exit");
            Console.WriteLine("Please Select an Operation:");
        }
        static void getAllCar(CarManager carManager)
        {
            Console.WriteLine("\n");
            Console.WriteLine("CarID  BrandID  ColorID Description DailyPrice");
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.CarId + "\t " + item.BrandId + "\t " + item.ColorId + "\t " + item.Description + "\t\t " + item.DailyPrice);
            }
            Console.WriteLine("\n");
        }
        static void addNewCar(CarManager carManager)
        {

            //carManager.Add(new Car
            //{
            //    CarId = 6,
            //    BrandId = 2,
            //    ColorId = 1,
            //    DailyPrice = 100,
            //    Description = "Audi",
            //    ModelYear = 2001
            //});

            Car car1 = new Car();
            Console.WriteLine("Enter Car ID:");
            car1.CarId = UInt16.Parse(Console.ReadLine());
            Console.WriteLine("Enter Brand ID:");
            car1.BrandId = UInt16.Parse(Console.ReadLine());
            Console.WriteLine("Enter Color ID:");
            car1.ColorId = UInt16.Parse(Console.ReadLine());
            Console.WriteLine("Enter DailyPrice:");
            car1.DailyPrice = UInt16.Parse(Console.ReadLine());
            Console.WriteLine("Enter Description:");
            car1.Description = Console.ReadLine();
            Console.WriteLine("Enter ModelYear:");
            car1.ModelYear = UInt16.Parse(Console.ReadLine());
            carManager.Add(car1);
        }
        static void updateCarInfo(CarManager carManager)
        {

            //carManager.Add(new Car
            //{
            //    CarId = 6,
            //    BrandId = 2,
            //    ColorId = 1,
            //    DailyPrice = 100,
            //    Description = "Audi",
            //    ModelYear = 2001
            //});

            Car car1 = new Car();
            Console.WriteLine("Enter Car ID:");
            car1.CarId = UInt16.Parse(Console.ReadLine());
            Console.WriteLine("Enter Brand ID:");
            car1.BrandId = UInt16.Parse(Console.ReadLine());
            Console.WriteLine("Enter Color ID:");
            car1.ColorId = UInt16.Parse(Console.ReadLine());
            Console.WriteLine("Enter DailyPrice:");
            car1.DailyPrice = UInt16.Parse(Console.ReadLine());
            Console.WriteLine("Enter Description:");
            car1.Description = Console.ReadLine();
            Console.WriteLine("Enter ModelYear:");
            car1.ModelYear = UInt16.Parse(Console.ReadLine());
            carManager.Update(car1);
        }

        static void deleteCar(CarManager carManager)
        {
            Car car1 = new Car();
            Console.WriteLine("Enter Car ID to DELETE:");
            car1.CarId = UInt16.Parse(Console.ReadLine());
            
            carManager.Delete(car1);
        }

        ///////////BRAND METHODS
        static void getAllBrand(BrandManager brandManager)
        {
            Console.WriteLine("\n");
            Console.WriteLine("BrandID  BrandName BrandAddress");
            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine(item.BrandId + "\t " + item.BrandName + "\t " + item.BrandAdress);
            }
            Console.WriteLine("\n");
        }
        static void addNewBrand(BrandManager brandManager)
        {

            //carManager.Add(new Car
            //{
            //    CarId = 6,
            //    BrandId = 2,
            //    ColorId = 1,
            //    DailyPrice = 100,
            //    Description = "Audi",
            //    ModelYear = 2001
            //});

            Brand brand1 = new Brand() ;
            Console.WriteLine("Enter Brand ID:");
            brand1.BrandId = UInt16.Parse(Console.ReadLine());
            Console.WriteLine("Enter Brand Name:");
            brand1.BrandName = Console.ReadLine();
            Console.WriteLine("Enter Brand Address:");
            brand1.BrandAdress = Console.ReadLine();

            brandManager.Add(brand1);
        }
        static void updateBrandInfo(BrandManager brandManager)
        {

            //carManager.Add(new Car
            //{
            //    CarId = 6,
            //    BrandId = 2,
            //    ColorId = 1,
            //    DailyPrice = 100,
            //    Description = "Audi",
            //    ModelYear = 2001
            //});

            Brand brand1 = new Brand();
            Console.WriteLine("Enter Brand ID:");
            brand1.BrandId = UInt16.Parse(Console.ReadLine());
            Console.WriteLine("Enter Brand Name:");
            brand1.BrandName = Console.ReadLine();
            Console.WriteLine("Enter Brand Address:");
            brand1.BrandAdress = Console.ReadLine();

            brandManager.Update(brand1);
        }

        static void deleteBrand(BrandManager brandManager)
        {
            Brand brand1 = new Brand();
            Console.WriteLine("Enter Brand ID to DELETE:");
            brand1.BrandId = UInt16.Parse(Console.ReadLine());

            brandManager.Delete(brand1);
        }
    }
}
