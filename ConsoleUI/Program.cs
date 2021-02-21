using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new  CarManager(new InMemoryCarDal());
            //BrandManager brandManager = new BrandManager(new InMemoryBrandDal());

            CarManager carManager = new CarManager(new EfCarDal());

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            byte choose = 0, op = 0;


            do
            {

                showMenu();
                choose = (byte)UInt16.Parse(Console.ReadLine());
                switch (choose)
                {

                    case 1:
                        {
                            do
                            {

                                showCarMenu();
                                op = (byte)UInt16.Parse(Console.ReadLine());
                                switch (op)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("\n--------CAR OPERATIONS MENU-----------\n");
                                        getAllCar(carManager);
                                        carMenuInfo(); break;
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("\n--------CAR OPERATIONS MENU-----------\n");
                                        addNewCar(carManager);
                                        carMenuInfo();  break;
                                    case 3:
                                        Console.Clear();
                                        Console.WriteLine("\n--------CAR OPERATIONS MENU-----------\n");
                                        updateCarInfo(carManager);
                                        carMenuInfo();  break;
                                    case 4:
                                        Console.Clear();
                                        Console.WriteLine("\n--------CAR OPERATIONS MENU-----------\n");
                                        deleteCar(carManager);
                                        carMenuInfo(); break;
                                    case 5:
                                        Console.Clear();
                                        Console.WriteLine("\n--------CAR OPERATIONS MENU-----------\n");
                                        getCarDetails(carManager); 
                                        carMenuInfo(); break;
                                    case 6:
                                        Console.Clear();
                                        Console.WriteLine("\n--------CAR OPERATIONS MENU-----------\n");
                                        getByDailyPrice(carManager);
                                        carMenuInfo(); break;

                                    case 0: break;
                                    default: Console.WriteLine("Wrong Chooice"); break;
                                }

                            } while (op != 0 );

                            break;
                        }
                    case 2:
                        {
                            do
                            {
                                showBrandMenu();
                                op = (byte)UInt16.Parse(Console.ReadLine());
                                switch (op)
                                {
                                    case 1:
                                        Console.Clear();
                                        getAllBrand(brandManager); 
                                        brandMenuInfo(); break;
                                    case 2:
                                        Console.Clear();
                                        addNewBrand(brandManager); 
                                        brandMenuInfo();  break;
                                    case 3:
                                        Console.Clear();
                                        updateBrandInfo(brandManager); 
                                        brandMenuInfo(); break;
                                    case 4:
                                        Console.Clear();
                                        deleteBrand(brandManager);
                                        brandMenuInfo(); break;

                                    case 0: break;
                                    default: Console.WriteLine("Wrong Chooice"); break;
                                }
                                
                            } while (op != 0);
                        }
                        break;


                    case 3:
                        {
                            do
                            {
                                showCustomerMenu();
                                op = (byte)UInt16.Parse(Console.ReadLine());
                                switch (op)
                                {
                                    case 1:
                                        Console.Clear();
                                        getAllCustomer(customerManager);
                                        customerMenuInfo();
                                        break;
                                    case 2:
                                        Console.Clear();
                                        addNewCustomer(customerManager);
                                        customerMenuInfo(); break;
                                    case 3:
                                        Console.Clear();
                                        updateCustomer(customerManager); 
                                        customerMenuInfo(); break;
                                    case 4:
                                        Console.Clear();
                                        deleteCustomer(customerManager); 
                                        customerMenuInfo(); break;


                                    case 0: break;
                                    default: Console.WriteLine("Wrong Chooice"); break;
                                }
                               
                            } while (op != 0);
                        }
                        break;

                    case 4:
                        {
                            do
                            {
                                showColorMenu();
                                op = (byte)UInt16.Parse(Console.ReadLine());
                                switch (op)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("\n--------COLOR OPERATIONS MENU-----------");
                                        getAllColor(colorManager);
                                        colorMenuInfo(); break;
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("\n--------COLOR OPERATIONS MENU-----------");
                                        addNewColor(colorManager);
                                        colorMenuInfo(); break;
                                    case 3:
                                        Console.Clear();
                                        Console.WriteLine("\n--------COLOR OPERATIONS MENU-----------");
                                        updateColor(colorManager);
                                        colorMenuInfo(); break;
                                    case 4:
                                        Console.Clear();
                                        Console.WriteLine("\n--------COLOR OPERATIONS MENU-----------");
                                        deleteColor(colorManager);
                                        colorMenuInfo(); break;

                                    case 0: break;
                                    default: Console.WriteLine("Wrong Chooice"); break;
                                }

                            } while (op != 0);
                        }
                        break;
                    case 5:
                        {
                            do
                            {
                                showRentalMenu();
                                op = (byte)UInt16.Parse(Console.ReadLine());
                                switch (op)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("\n--------RENTAL OPERATIONS MENU-----------");
                                        getRentalCars(rentalManager);
                                        rentalMenuInfo(); break;
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("\n--------RENTAL OPERATIONS MENU-----------");
                                        rentNewCar(rentalManager);
                                        rentalMenuInfo(); break;
                                    case 3:
                                        Console.Clear();
                                        Console.WriteLine("\n--------RENTAL OPERATIONS MENU-----------");
                                        updateRentCar(rentalManager);
                                        rentalMenuInfo(); break;
                                    case 4:
                                        Console.Clear();
                                        Console.WriteLine("\n--------RENTAL OPERATIONS MENU-----------");
                                        deleteRentCar(rentalManager);
                                        rentalMenuInfo(); break;

                                    case 0: break;
                                    default: Console.WriteLine("Wrong Chooice"); break;
                                }

                            } while (op != 0);
                        }
                        break;


                    case 0: break;
                    default: Console.WriteLine("Wrong Chooice"); break;
                }
            } while (choose != 0);






            static void showMenu()
            {
                Console.Clear();
                Console.WriteLine("\n------------RENT A CAR----------\n");
                Console.WriteLine("1-CAR OPERATIONS\n" +

                    "2-BRAND OPERATIONS\n" +
                    "3-CUSTOMER OPERATIONS\n" +
                    "4-COLOR OPERATIONS\n" +
                    "5-RENTAL OPERATIONS\n\n" +
                    "0-Exit");
                Console.WriteLine("(Main Menu)Please Select an Operation:");
            }
            static void showCarMenu()
            {
                Console.Clear();
                Console.WriteLine("\n--------CAR OPERATIONS-----------");
                Console.WriteLine("1-Show All CARS\n" +
                    "2-Add a New Car\n" +
                    "3-Updade Car's info\n" +
                    "4-Delete a Car\n" +
                    "5-Car Details'\n" +
                    "6-Search a Car by Daily Price'\n\n" +
                    "0-Back to Main Menu");
                Console.WriteLine("(Car Menu)Please Select an Operation:");
            }
            static void showBrandMenu()
            {
                Console.Clear();
                Console.WriteLine("\n--------BRAND OPERATIONS-----------");
                Console.WriteLine(
                    "1-Show All BRANDS\n" +
                    "2-Add a New Brand\n" +
                    "3-Update Brand's Info\n" +
                    "4-Delete a Brand'\n\n" +

                    "0-Back to Main Menu");
                Console.WriteLine("(Brand Menu)Please Select an Operation:");
            }
            static void showCustomerMenu()
            {

                Console.Clear();
                Console.WriteLine("\n--------CUSTOMER OPERATIONS-----------");
                Console.WriteLine(
                    "1-Customer ALL INFO\n" +
                     "2-Add a Customer\n" +
                    "3-Update Customer's Info\n" +
                    "4-Delete a Customer'\n\n" +

                    "0-Back to Main Menu");
                Console.WriteLine("(Customer Menu)Please Select an Operation:");
            }
            static void showColorMenu()
            {

                Console.Clear();
                Console.WriteLine("\n--------COLOR OPERATIONS-----------");
                Console.WriteLine(
                    "1-COLOR ALL INFO\n" +
                     "2-Add a Color\n" +
                    "3-Update Color's Info\n" +
                    "4-Delete a Color'\n\n" +

                    "0-Back to Main Menu");
                Console.WriteLine("(Color Menu)Please Select an Operation:");
            }

            static void showRentalMenu()
            {

                Console.Clear();
                Console.WriteLine("\n--------RENTAL OPERATIONS-----------");
                Console.WriteLine(
                    "1-Rental ALL INFO\n" +
                     "2-Rent a Car\n" +
                    "3-Rent Update Car's Info\n" +
                    "4-Rent Delete a Car'\n\n" +

                    "0-Back to Main Menu");
                Console.WriteLine("Please Select an Operation:");
            }

            static void getAllCar(CarManager carManager)
            {
                var result = carManager.GetAll();
                if(result.Success)
                {
                    foreach (var item in result.Data)
                     {
                   Console.WriteLine(item.CarId + "\t " + item.BrandId + "\t " + item.ColorId + "\t " + item.Description + "\t\t " + item.DailyPrice);
                      }
                }
                else
                {
                    Console.WriteLine(result.Message);
                }

                ////bunun yerine yukarda kodları yazdık
                //Console.WriteLine("\n");
                //Console.WriteLine("CarID  BrandID  ColorID Description DailyPrice");
                //foreach (var item in carManager.GetAll().Data)
                //{
                //    Console.WriteLine(item.CarId + "\t " + item.BrandId + "\t " + item.ColorId + "\t " + item.Description + "\t\t " + item.DailyPrice);
                //}


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
                /* databasede autoincrement yapigim icin kapattım
                //
                //Console.WriteLine("Enter Car ID:");
                //car1.CarId = UInt16.Parse(Console.ReadLine());
                */
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
                Console.WriteLine("\n{0} Id Car's Info ADDED", car1.CarId);
                getAllCar(carManager);

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
                
                getAllCar(carManager);
                Car car1 = new Car();
                Console.WriteLine("Please Select Car ID to Update :");
                car1.CarId = UInt16.Parse(Console.ReadLine());
                carManager.GetById(car1.CarId);
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
                Console.WriteLine("\n{0} Id Car's Info UPDATED",car1.CarId);
                getAllCar(carManager);

            }

            static void deleteCar(CarManager carManager)
            {
                Car car1 = new Car();
                Console.WriteLine("Enter Car ID to DELETE:");
                car1.CarId = UInt16.Parse(Console.ReadLine());

                carManager.Delete(car1);
                getAllCar(carManager);
            }
            static void getByDailyPrice(CarManager carManager)
            {
                decimal dailyMin, dailyMax;
                Console.WriteLine("Enter Min Daily Price:");
                dailyMin = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter Max Daily Price:");
                dailyMax = decimal.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("CarID  BrandID  ColorID Description DailyPrice");

                //foreach (var item in carManager.GetByDailyPrice(dailyMin, dailyMax).Data)

                var result = carManager.GetByDailyPrice(dailyMin, dailyMax);
                if (result.Success)
                {
                    foreach (var item in result.Data)
                    {
                        Console.WriteLine(item.CarId + "\t " + item.BrandId + "\t " + item.ColorId + "\t " + item.Description + "\t\t " + item.DailyPrice);
                    }

                    Console.WriteLine("\n\nFiltered by min {0} and max {1} Daily Price", dailyMin, dailyMax);
                }
                else
                {
                    Console.WriteLine(result.Message);
                }
             
            }

            static void getCarDetails(CarManager carManager)
            {

                var result = carManager.GetCarDetails();
                if (result.Success) { 

                    Console.WriteLine("\n");
                    Console.WriteLine("CarName  CustomerName  Color         Payment   DailyPrice   CarId");
                    foreach (var carDetail in result.Data)
                    {
                        Console.WriteLine(carDetail.CarName + "\t " + carDetail.CustomerName + "\t " + carDetail.ColorName + "\t " + carDetail.Payment + "\t " + carDetail.DailyPrice + "\t " + carDetail.CarId);
                    }
                }
                else
                {
                    Console.WriteLine(result.Message);
                }


            }
            ///////////BRAND METHODS 
            static void getAllBrand(BrandManager brandManager)
            {
                Console.WriteLine("\n");
                Console.WriteLine("BrandID  BrandName BrandAddress");
                //  foreach (var item in brandManager.GetAll())//IResult kısmını ekledikten sonra asgıdaki kod ile degistirdim
                var result = brandManager.GetAll();
                if (result.Success) { 
                    foreach (var item in result.Data)
                    {
                        Console.WriteLine(item.BrandId + "\t " + item.Name + "\t " + item.Adress);
                    }
                }
               else
                {
                    Console.WriteLine(result.Message);
                }


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

                Brand brand1 = new Brand();
                Console.WriteLine("Enter Brand ID:");
                brand1.BrandId = UInt16.Parse(Console.ReadLine());
                Console.WriteLine("Enter Brand Name:");
                brand1.Name = Console.ReadLine();
                Console.WriteLine("Enter Brand Address:");
                brand1.Adress = Console.ReadLine();

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
                brand1.Name = Console.ReadLine();
                Console.WriteLine("Enter Brand Address:");
                brand1.Adress = Console.ReadLine();

                brandManager.Update(brand1);
                
            }

            static void deleteBrand(BrandManager brandManager)
            {
                Brand brand1 = new Brand();
                Console.WriteLine("Enter Brand ID to DELETE:");
                brand1.BrandId = UInt16.Parse(Console.ReadLine());

                brandManager.Delete(brand1);
               
            }
            ///////////CUSTOMER METHODS
            static void getAllCustomer(CustomerManager customerManager)
            {

                var result = customerManager.GetAll();
                if (result.Success) { 
                    Console.WriteLine("\n");
                    Console.WriteLine("CustomerID  CarID  Payment PaymetType PaymentDate");
                    //foreach (var customer in customerManager.GetAll())
                    foreach (var customer in result.Data)
                    {
                        Console.WriteLine(customer.Id + "\t " + customer.CustomerName + "\t " + customer.Payment + "\t " + customer.PaymetType + "\t\t " + customer.PaymentDate);
                    }

                }
                else
                {
                    Console.WriteLine(result.Message);
                }

            }
            static void addNewCustomer(CustomerManager customerManager)
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

                Customer customer = new Customer();
                /* databasede autoincrement yapigim icin kapattım
                //
                //Console.WriteLine("Enter Car ID:");
                //car1.CarId = UInt16.Parse(Console.ReadLine());
                */
                //Console.WriteLine("Enter Brand ID:");
                //customer.CustomerId = UInt16.Parse(Console.ReadLine());
                Console.WriteLine("Enter Customer Name:");
                customer.CustomerName = Console.ReadLine();
                Console.WriteLine("Enter Payment Value:");
                customer.Payment = UInt16.Parse(Console.ReadLine());
                Console.WriteLine("Enter Payment Type:");
                customer.PaymetType = Console.ReadLine();
                Console.WriteLine("Enter Payment Date:");
                customer.PaymentDate = DateTime.Parse(Console.ReadLine());
                customerManager.Add(customer);
                Console.WriteLine("\n{0} Id Customer Info ADDED", customer.Id);
                getAllCustomer(customerManager);

            }
            static void updateCustomer(CustomerManager customerManager)
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
                getAllCustomer(customerManager);
                Customer customer = new Customer();
                Console.WriteLine("Please Select Customer ID to Update :");
                customer.Id = UInt16.Parse(Console.ReadLine());
                customerManager.GetById(customer.Id);
                Console.WriteLine("Enter Customer Name:");
                customer.CustomerName = Console.ReadLine();
                Console.WriteLine("Enter Customer's Payment:");
                customer.Payment = UInt16.Parse(Console.ReadLine());
                Console.WriteLine("Enter Payment Type:");
                customer.PaymetType = Console.ReadLine();
                Console.WriteLine("Enter Payment Date:");
                customer.PaymentDate = DateTime.Parse(Console.ReadLine());

                customerManager.Update(customer);
                
            }

            static void deleteCustomer(CustomerManager customerManager)
            {
                Customer customer1 = new Customer();
                getAllCustomer(customerManager);
                Console.WriteLine("Enter Customer ID to DELETE:");
                customer1.Id = UInt16.Parse(Console.ReadLine());
                //customer1 = customerManager.GetById(customer1.CustomerId);
                customer1 = customerManager.GetById(customer1.Id).Data;
                customerManager.Delete(customer1);
                
            }



            ///////////Color METHODS
            static void getAllColor(ColorManager colorManager)
            {
                var result = colorManager.GetAll();
                if (result.Success) { 

                Console.WriteLine("\n");
                Console.WriteLine("ColorId  Name  Description");
                foreach (var color1 in result.Data)
                {
                    Console.WriteLine(color1.ColorId + "\t " + color1.Name + "\t " + color1.Description );
                }
                }
                else
                {
                    Console.WriteLine(result.Message);
                }

            }
            static void addNewColor(ColorManager colorManager)
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

                Color color1 = new Color();
                /* databasede autoincrement yapigim icin kapattım
                //
                //Console.WriteLine("Enter Car ID:");
                //car1.CarId = UInt16.Parse(Console.ReadLine());
                */
                //Console.WriteLine("Enter Brand ID:");
                //customer.CustomerId = UInt16.Parse(Console.ReadLine());
                Console.WriteLine("Enter Color Name:");
                color1.Name = Console.ReadLine();
                Console.WriteLine("Enter Color Description:");
                color1.Description = Console.ReadLine();
                
                colorManager.Add(color1);


            }
            static void updateColor(ColorManager colorManager)
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
                getAllColor(colorManager);
                Color color1 = new Color();
                Console.WriteLine("Please Select Color ID to Update :");
                color1.ColorId = UInt16.Parse(Console.ReadLine());
                colorManager.GetById(color1.ColorId);
                Console.WriteLine("Enter Color Name:");
                color1.Name = Console.ReadLine();
                
                Console.WriteLine("Enter Color Description Type:");
                color1.Description = Console.ReadLine();
             

                colorManager.Update(color1);

            }

            static void deleteColor(ColorManager colorManager)
            {
                Color color1 = new Color();
                getAllColor(colorManager);
                Console.WriteLine("Enter Color ID to DELETE:");
                color1.ColorId = UInt16.Parse(Console.ReadLine());
                // color1 = colorManager.GetById(color1.ColorId);
                color1 = colorManager.GetById(color1.ColorId).Data;
                colorManager.Delete(color1);

            }

        }

        ///////////RENTAL METHODS
        static void getRentalCars(RentalManager rentalManager)
        {
            var result = rentalManager.GetAll();
            if (result.Success)
            {

                Console.WriteLine("\n");
                Console.WriteLine("RentId CarId  CustomerId  RentDate ReturnDate");
                foreach (var rentcar in result.Data)
                {
                    Console.WriteLine(rentcar.Id + "\t " + rentcar.CarId + "\t " + rentcar.CustomerId + "\t " + rentcar.RentDate + "\t " + rentcar.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
        static void rentNewCar(RentalManager rentalManager)
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

            Rental rent = new Rental();
            /* databasede autoincrement yapigim icin kapattım
            //
            //Console.WriteLine("Enter Car ID:");
            //car1.CarId = UInt16.Parse(Console.ReadLine());
            */
            //Console.WriteLine("Enter Brand ID:");
            //customer.CustomerId = UInt16.Parse(Console.ReadLine());
            Console.WriteLine("Enter Car ID:");
            rent.CarId = UInt16.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer ID:");
            rent.CustomerId = UInt16.Parse(Console.ReadLine());
            Console.WriteLine("Enter Rent Date:");
            rent.RentDate =DateTime.Parse( Console.ReadLine());
            //Console.WriteLine("Enter Return Date");
            //rent.ReturnDate = DateTime.Parse(Console.ReadLine());
            rent.ReturnDate = null;
              rentalManager.Add(rent);


        }
        static void updateRentCar(RentalManager rentalManager)
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
            getRentalCars(rentalManager);
             
                Rental rent = new Rental();
            
            //Console.WriteLine("Please Select Rent ID to Update :");
            //rent.Id = UInt16.Parse(Console.ReadLine());
            //rentalManager.GetById(rent.Id);
            Console.WriteLine("Enter Car ID:");
            rent.CarId = UInt16.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Customer ID:");
            //rent.CustomerId = UInt16.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Rent Date:");
            //rent.RentDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Rent Return Date:");
            rent.ReturnDate = DateTime.Parse(Console.ReadLine());


            // Console.WriteLine("carid:{0}, cusId:{1},rentdate:{2},returndate:{3}",result.Data.CarId,result.Data.CustomerId,result.Data.RentDate,result.Data.ReturnDate);

            var result = rentalManager.GetByCarId(rent.CarId);
            rent.Id = result.Data.Id;
            rent.CustomerId = result.Data.CustomerId;
            rent.RentDate = result.Data.RentDate;

            rentalManager.Update(rent);

        }

        static void deleteRentCar(RentalManager rentalManager)
        {
            Rental rent = new Rental();
            getRentalCars(rentalManager);
            Console.WriteLine("Enter Rent ID to DELETE:");
            rent.Id = UInt16.Parse(Console.ReadLine());
            // color1 = colorManager.GetById(color1.ColorId);
            rent = rentalManager.GetById(rent.Id).Data;
            rentalManager.Delete(rent);

        }

        private static void rentalMenuInfo()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\nPress any key back to RENTAL OPERATIONS menu");
            Console.ReadLine();
        }

        private static void colorMenuInfo()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\nPress any key back to COLOR OPERATIONS menu");
            Console.ReadLine();
        }
        private static void customerMenuInfo()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\nPress any key back to CUSTOMER OPERATIONS menu");
            Console.ReadLine();
        }
        private static void brandMenuInfo()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\nPress any key back to BRAND OPERATIONS menu");
            Console.ReadLine();
        }
        private static void carMenuInfo()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\nPress any key back to CAR OPERATIONS menu");
            Console.ReadLine();
        }
    }
}


