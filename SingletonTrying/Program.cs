using System;
using System.ComponentModel;

namespace SingletonTrying
{

    public class Try
    {
        private static Try Instance;

        public Try()
        {
        }
        
        public static Try GiveMoney()
        {
            if (Instance == null)
            {
                Instance = new Try();
            }
            return Instance;
        }
    }


    public class Deneme
    {
        private static Deneme dene;

        public Deneme()
        {
        }

        public static Deneme ITruToYou()
        {
            if (dene == null)
            {
                dene = new Deneme();
            }
            return dene;
        }


    }




    public class Programw
    {
        static void Main(string[] args)
        {
            //Try instance = new Try();
            Try Instance = Try.GiveMoney(); // Bu şekilde aynı
            Try Instance2 = Try.GiveMoney();
            Try Instance3 = Try.GiveMoney();
            Try Instance4 = Try.GiveMoney();
            //Bu sayede aynı nesneden birden fazla new'lemeden oluşturmuş olduk.

            Deneme dene = Deneme.ITruToYou();

            if (Instance.Equals(dene))
            {
                Console.WriteLine("Objects is same");
                Console.WriteLine("Do you agree with me?");


            }
            else
            {
                Console.WriteLine("Object is not same");
                Console.WriteLine("Do you agree with me?"); ;
            }
        
        }
    }
}
