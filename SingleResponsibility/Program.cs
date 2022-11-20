using System;

namespace SingleResponsibility
{

  //Her metod ve class'In tek bir görev sorumluluğu vardır.Single responsibility'e göre.

    
    public class Customer
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public void CreateCustomer(Customer customer)
        {
            //Customer Created
        }
    }

    public class File
    {
        public void SaveToFile(Customer customer)
        {
            //Customer saved to file
        }
    }







    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
