using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            // ColorTest();
            // BrandTest();
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            List<Brand> brands = brandManager.GetAll();

            foreach (Brand brand in brands)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            List<Color> colors = colorManager.GetAll();

            foreach (Color color in colors)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            List<CarDetailDto> cars = carManager.GetCarDetails();

            foreach (var car in cars)
            {
                Console.WriteLine(car.CarDescription + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
            }
        }
    }
}
