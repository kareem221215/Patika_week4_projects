using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota" , "Corolla" ,"red" , 4);
            Console.WriteLine($"Car brand: {car1.Brand} Car model: {car1.Model} Car color: {car1.Color} Number of doors: {car1.numberOfDoors}");

            Car car2 = new Car("Honda", "Civic", "Blue", 5);
            Console.WriteLine($"Car brand: {car2.Brand} Car model: {car2.Model} Car color: {car2.Color} Number of doors: {car2.numberOfDoors}");

            Car car3 = new Car("Ford", "Focus", "Black", 2);
            Console.WriteLine($"Car brand: {car3.Brand} Car model: {car3.Model} Car color: {car3.Color} Number of doors: {car3.numberOfDoors}");
        }
        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }

            public Car(string brandname, string model, string color, int NumberOfDoors)
            {
                Brand = brandname;
                Model = model;
                Color = color;
                numberOfDoors = NumberOfDoors;
            }

            private int _numberOfDoors;
            public int numberOfDoors
            {
                get { return _numberOfDoors; }
                set
                {
                    if (value == 2 || value == 4)
                    {
                        _numberOfDoors = value;
                    }
                    else
                    {
                        Console.WriteLine("number of doors should be 2 or 4, setting value to -1");
                        _numberOfDoors = -1;
                    }
                }
            }



        }
    }
}
