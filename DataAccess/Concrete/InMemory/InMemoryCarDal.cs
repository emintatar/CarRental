using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2015,DailyPrice=150,CarDescription="Audi A3"},
                new Car{CarId=2,BrandId=1,ColorId=2,ModelYear=2016,DailyPrice=200,CarDescription="Audi A4"},
                new Car{CarId=3,BrandId=2,ColorId=3,ModelYear=2017,DailyPrice=250,CarDescription="BMW 3.20"},
                new Car{CarId=4,BrandId=2,ColorId=4,ModelYear=2018,DailyPrice=300,CarDescription="BMW 5.20"},
                new Car{CarId=5,BrandId=3,ColorId=5,ModelYear=2019,DailyPrice=350,CarDescription="Mercedes C180"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.FirstOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            Car carToSelect = _cars.FirstOrDefault(c => c.CarId == id);
            return carToSelect;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.CarDescription = car.CarDescription;
        }
    }
}
