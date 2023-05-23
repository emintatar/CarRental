﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2015,DailyPrice=150,Description="Audi A3"},
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear=2016,DailyPrice=200,Description="Audi A4"},
                new Car{Id=3,BrandId=2,ColorId=3,ModelYear=2017,DailyPrice=250,Description="BMW 3.20"},
                new Car{Id=4,BrandId=2,ColorId=4,ModelYear=2018,DailyPrice=300,Description="BMW 5.20"},
                new Car{Id=5,BrandId=3,ColorId=5,ModelYear=2019,DailyPrice=350,Description="Mercedes C180"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.FirstOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            Car carToSelect = _cars.FirstOrDefault(c => c.Id == id);
            return carToSelect;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
