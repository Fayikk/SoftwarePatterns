using System;
using System.Collections.Generic;

namespace CompositeOneMore
{
    public interface Pc
    {
        public void ShowInfos();
    }

    public class Apple : Pc
    {
        public string Brand;
        public string Name;
        public string Description;
        public string Price;

        public Apple(string brand, string name, string description, string price)
        {
            Brand = brand;
            Name = name;
            Description = description;
            Price = price;
        }

        public void ShowInfos()
        {
            Console.WriteLine("Computer Brand is" + Brand);
            Console.WriteLine("Computer Name is" + Name);
            Console.WriteLine("Computer Description is " + Description);
            Console.WriteLine("Computer Price is " + Price);
        }
    }


    public class Lenovo : Pc
    {

        public string Brand;
        public string Name;
        public string Description;
        public string Price;

        public Lenovo(string brand, string name, string description, string price)
        {
            Brand = brand;
            Name = name;
            Description = description;
            Price = price;
        }

        public void ShowInfos()
        {
            Console.WriteLine("Computer Brand is " + Brand);
            Console.WriteLine("Computer Name is" + Name);
            Console.WriteLine("Computer Description is " + Description);
            Console.WriteLine("Computer Price is " + Price);
        }
    }

    public class Composite : Pc
    {
        public List<Pc> pc;
        string[] Pc = { "Asus", "Lenovo" };

        public void Add(string deneme)
        {
            Add(deneme);
        }
        public void Remove(Pc p)
        {
            pc.Remove(p);
        }

      

        public void ShowInfos()
        {
            foreach (var p in pc)
            {
                Console.WriteLine("Stock pc for us" + p);
            }
        }
    }

    //Genel itibariyle composite deseni diğerlerinden ayıran özellik'te composite class içerisine Ana interface sınıfı kullanmak için
    //Class içerisinde instance'ını oluşturuyoruz.





    internal class Program
    {


        


        static void Main(string[] args)
        {
        String[] pc = { "Asus", "Apple", "MAC" };

            foreach (var p in pc)
            {
                Console.WriteLine(p);
            }


            //Composite composite = new Composite();
            ////composite.Add("Asus");
            //composite.ShowInfos();
        }
    }
}
