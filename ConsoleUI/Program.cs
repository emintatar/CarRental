using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarService carManager = new CarManager(new InMemoryCarDal());

            List<Car> cars = carManager.GetAll();

            foreach (Car car in cars)
            {
                Console.WriteLine(car.Id + " " + car.Description);
            }
        }
    }
}
