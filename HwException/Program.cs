using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace HwException
{
    public class Program
    {
        public static Logger log = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();

            try
            {
                //carList.AddCar(0, "newCar", 2013);
                //carList.AddCar(1, "Chevrolet Camaro", 1966);
                //carList.AddCar(2, "Jaguar XJS", 1975);
                //carList.AddCar(3, "Cadillac", 1959);
                //carList.AddCar(4, "Mustang", 1970);
                //carList.AddCar(5, "Chevrolet Impala", 1964);

                Car car = new Car();

                car.KmControlEvent += Car_KmControlEvent;
                car.Id = 1;
                car.Name = "carcar";
                car.Model = 2015;

                for (int i = 0; i < 5; i++)
                {
                    car.Kilometers += 12;
                }
            }
            catch (CarModelException modelException)
            {
                log.ErrorException($"{modelException.Message}! Car Model={modelException.CarModel}", modelException);
            }
            finally
            {
                foreach (var car in carList)
                {
                    //Console.WriteLine($"{car.Name} => {car.Model}");
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }

        private static void Car_KmControlEvent(object ob)
        {
            Console.WriteLine("Km is over 45km! ");

        }
    }
}
