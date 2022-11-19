    using System;

namespace AdapterTrying
{


    public interface İslem
    {
        public void Toplama();
        public void Cikarma();
    }


    public class Islem1 : İslem
    {
        public void Cikarma()
        {
            Console.WriteLine("iki sayının farkıdır");
        }

        public void Toplama()
        {
            Console.WriteLine("İki sayının toplamıdır");
        }
    }


    public class islem2 : İslem
    {
        public void Cikarma()
        {
            Console.WriteLine("iki sayının farkıdır");
        }

        public void Toplama()
        {
            Console.WriteLine("İki sayının toplamıdır");
        }
    }

    //Şimdi birde adapter oluşturalım

    public class Deneme
    {
        public void SayilariTopla()
        {
            Console.WriteLine("Sayıların Tpolmaıdır");
        }
        public void SayilariCikar()
        {
            Console.WriteLine("Sayıların farkı anlamına gelmektedir");
        }
    }


    public class Adapter : İslem
    {
        Deneme deneme;

        public Adapter(Deneme deneme)
        {
            this.deneme = deneme;
        }

        public void Cikarma()
        {
            deneme.SayilariCikar();
        }

        public void Toplama()
        {
            deneme.SayilariTopla();
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
