using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwException
{
    public static class AddCarMethod
    {
        public static List<Car> AddCar(this List<Car> cars, int id, string name, int model)
        {
            Car car = new Car();
            car.Id = id;
            car.Name = name;
            car.Model = model;
            cars.Add(car);
            return cars;
        }
    }
}
