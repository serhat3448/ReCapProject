﻿using DataAccess.Abstract;
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
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=120000, ModelYear=2020, Description="Sedan Car"},
                new Car{Id=2, BrandId=1, ColorId=2, DailyPrice=100000, ModelYear=2018, Description="Sedan Car"},
                new Car{Id=3, BrandId=2, ColorId=3, DailyPrice=125000, ModelYear=2020, Description="Sedan Car"},
                new Car{Id=4, BrandId=3, ColorId=4, DailyPrice=110000, ModelYear=2019, Description="SUV Car"},
                new Car{Id=5, BrandId=3, ColorId=2, DailyPrice=145000, ModelYear=2020, Description="Station Wagon Car"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
