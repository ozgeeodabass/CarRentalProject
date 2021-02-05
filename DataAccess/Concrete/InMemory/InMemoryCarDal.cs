using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car { CarId=1, BrandId=1, ColorId=2, ModelYear=2000, DailyPrice=500, Description="Fiat Marka Araba" },
                new Car { CarId=2, BrandId=2, ColorId=1, ModelYear=2005, DailyPrice=800, Description="Hyundai Marka Araba" },
                new Car { CarId=3, BrandId=3, ColorId=2, ModelYear=1985, DailyPrice=300, Description="Lada Marka Araba" },
                new Car { CarId=4, BrandId=1, ColorId=3, ModelYear=2002, DailyPrice=650, Description="Fiat Marka Araba" },
                new Car { CarId=5, BrandId=4, ColorId=4, ModelYear=2009, DailyPrice=1000, Description="Volvo Marka Araba" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
           return _cars.Where(c => c.CarId == Id).ToList();

        }

        public void Update(Car car)
        {
           Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
