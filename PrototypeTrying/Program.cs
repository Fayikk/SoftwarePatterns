using System;
using System.Transactions;

namespace PrototypeTrying
{
    public class CarBots : ICloneable
    {
        public string Brand;
        public string Model;
        public string Name;
        public decimal DailyPrice;
        public int Speed;

        public bool isAvailebleForGame;
        public CarBots(string brand, string model, string name, decimal dailyPrice, int speed)
        {
            Brand = brand;
            Model = model;
            Name = name;
            DailyPrice = dailyPrice;
            Speed = speed;
        }

        public Object Clone()
        {
            CarBots car = null;
            try
            {
                car = (CarBots)isAvailebleForGame.Equals();

            }
            catch (Exception)
            {

                Console.WriteLine("Soldier copied moment one exception");
            }
            return car;

        }
    }


    //Yani burada önemli olan aslına bakarsanız klonalyıcı olarak görev alan,ICloneable interface'imizdir.
    //isAvailable ile uyumluluğunun olup olmadığını kontrol ediyorum.






    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
