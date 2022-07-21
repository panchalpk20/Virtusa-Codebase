using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    class Car
    {
        public string Model;
        public double Price;
        public int Making;
    }
    class CarRepository
    {
        private Car[] cars = new Car[10];
        int idx = 0;
        public void AddCar(Car car) //Add cars to array
        {
            if (idx < cars.Length)
            {
                cars[idx] = car;
                idx++;
            }
            else
            {
                Console.WriteLine("Garage is full");
            }
        }
        public Car[] GetAllCars()
        {
            return cars; //return all the Car objects
        }
        public Car GetCarByModel(string model)
        {
            //Serch a car in Cars array
            foreach(Car c in cars)
            {
                if (c != null) //checking the reference of c
                {
                    if (c.Model == model)
                    {
                        return c;
                    }
                }
            }
            return null;
        }
    }
    class Test_CarRepository
    {
        static void Main()
        {
            CarRepository repository = new CarRepository();
            do
            {
                Console.WriteLine("1.AddCar");
                Console.WriteLine("2.GetCarByModel");
                Console.WriteLine("3.GetAllCars");
                Console.WriteLine("4.Exit App");
                Console.WriteLine("Enter your Choice");
                int ch = int.Parse(Console.ReadLine()); //reads value from console
                switch(ch)
                {
                    case 1:
                        {
                            Car car = new Car();
                            Console.WriteLine("Enter Model");
                            car.Model = Console.ReadLine();
                            Console.WriteLine("Enter Price");
                            car.Price = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Year of Making");
                            car.Making = int.Parse(Console.ReadLine());
                            repository.AddCar(car);

                        }
                        break;
                    case 2:
                        {
                            //Searching Car
                            Console.WriteLine("Enter Model Name");
                            string model = Console.ReadLine();
                            Car car = repository.GetCarByModel(model);
                            if(car!=null)
                            {
                                Console.WriteLine(" Year: {0} Price:{1}", car.Making, car.Price);
                            }
                            else
                            {
                                Console.WriteLine("Given model cars are not exist");
                            }
                        }
                        break;
                    case 3:
                        {
                            Car[] cars = repository.GetAllCars();
                            foreach(Car c in cars)
                            {
                                if(c!=null) //to check object c is having reference or not
                                {
                                    Console.WriteLine("Relase Year: {0} Price:{1} Model:{2}", c.Making, c.Price,c.Model);
                                }
                            }
                        }
                        break;
                    case 4:
                        {
                            Environment.Exit(0); //exit app
                        }
                        break;
                }
            } while (true);
        }
    }
    
}
