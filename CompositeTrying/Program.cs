using System;
using System.Collections.Generic;

namespace CompositeTrying
{
    public interface Car
    {
        public void plaka();
    }


    public class Mercedes : Car
    {
        public string Brand;
        public int Model;
        public int NumberPlate;
        public Mercedes(string brand, int model,int numberPlate)
        {
            Brand = brand;
            Model = model;
            NumberPlate = numberPlate;
        }

        public void plaka()
        {
            Console.WriteLine("Aracımızın plakaası" + NumberPlate);
            Console.WriteLine("Aracımızın Markası" + Brand);
            Console.WriteLine("Aracımızın Modeli" + Model);
        }
    }


    public class Bmw : Car
    {
        public string Brand;
        public int Model;
        public int NumberPlate;

        public Bmw(string brand, int model, int numberPlate)
        {
            Brand = brand;
            Model = model;
            NumberPlate = numberPlate;
        }

        public void plaka()
        {
            Console.WriteLine("Aracımzın Plakası: " + NumberPlate);
            Console.WriteLine("Aracımzın Markası: " + Brand);
            Console.WriteLine("Aracımzın Modeli: " + Model);
        }
    }


    public class CarContainer : Car
    {
        public List<Car> cars;

        

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void plaka()
        {
            foreach (var car in cars)
            {
                car.plaka();
            }
        }

        public void RemoveCar(Car car)
        {
            cars.Remove(car);
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
