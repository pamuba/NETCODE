using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemo
{
    class Cars
    {
        public static List<Car> GetCars() { 
            return new List<Car>() { 
                new Car(){ Owner="Mike" , Type=CarType.HatchBacks},
                new Car(){ Owner="Emma" , Type=CarType.Sedan},
                new Car(){ Owner="John" , Type=CarType.SUV}
            }.ToList();
        }
    }
}
