using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DaySix
{
    public enum Fueltype { Disel, Petrol };
        public class Car
        {
            public string RegistrationNo { get; set; }
            public string Model { get; set; }
            public FuelType Fuel { get; set; }
            public Wheel[] Wheels { get; private set; }
            public Engine CarEngine { get; private set; }

            public Car(string registrationNo, string model, FuelType fuel)
            {
                RegistrationNo = registrationNo;
                Model = model;
                Fuel = fuel;
                Wheels = new Wheel[4];
                for (int i = 0; i < 4; i++)
                {
                    Wheels[i] = new Wheel();
                }
                CarEngine = new Engine();
            }

            public class Wheel
            {
                public int Diameter { get; set; }
                public string Material { get; set; }

                
            }

        }


        public class Engine
        {
          
                public int Horsepower { get; set; }
        }
 

   /* public class Details
    {
        public static void Test()
        {
            Car obj = new Car("111", "Hyundai", Car.FuelType.Diesel);
            Console.WriteLine($"Registration no:{Car.RegistrationNo}");
            Console.WriteLine(Car.Model);
            Console.WriteLine();
    
    }*/
    
    public enum FuelType
    {
        Gasoline,
        Diesel,
        Electric,
        Hybrid
    }
}
 
