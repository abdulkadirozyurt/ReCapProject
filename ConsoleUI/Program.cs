﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test1();

            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}


            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Araç Adı: "+car.CarName);
                Console.WriteLine("Marka: " + car.BrandName);
                Console.WriteLine("Renk: " + car.ColorName);
                Console.WriteLine("Günlük Fiyat: "+car.DailyPrice);
                

            }














        }

        private static void Test1()
        {
            CarManager carManager = new CarManager(new EfCarDal());




            Car car1 = new Car
            {
                CarId = 1,
                BrandId = 1,
                CarName = "Ferrari",
                ColorId = 8,
                ModelYear = 2012,
                DailyPrice = 350,
                Description = "F12 berlinetta"

            };

            carManager.Add(car1);

            Car car2 = new Car
            {
                CarId = 2,
                BrandId = 2,
                CarName = "Renault",
                ColorId = 3,
                ModelYear = 1994,
                DailyPrice = 50,
                Description = "12 Toros"
            };

            carManager.Add(car2);









            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Name: " + car.CarName);
                Console.WriteLine("Car BrandId: " + car.BrandId);
                Console.WriteLine("Car Color Id: " + car.ColorId);
                Console.WriteLine("Car Daily Price: " + car.DailyPrice);
                Console.WriteLine("Car Description: " + car.Description);

                Console.WriteLine("************************************");
            }
        }
    }
}
