using System;

namespace Singletonnn
{
    //Singleton Class Examples

    public class Singleton
    {
        private Singleton()
        {
        }
        private  static Singleton Instance;

        public static Singleton GiveObject()
        {
            if (Instance == null)
            {
                Instance = new Singleton();
            }
            return Instance;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Singleton nesne1 = new Singleton(); //Sİngleton sınıfından bu şekilde nesne oluşturamayız.
            Singleton  nesne1 = Singleton.GiveObject();//Ancak sınıf içerindeli metodlara vb erişim sağlanabilmektedir.
            Singleton nesne2 = Singleton.GiveObject();
            if (nesne1.Equals(nesne2))
            {
                Console.WriteLine("Objects is same");
            }
            else
            {
                Console.WriteLine("Objects is not same");
            }

        }
    }
}
