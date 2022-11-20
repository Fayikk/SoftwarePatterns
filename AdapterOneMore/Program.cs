using System;

namespace AdapterOneMore
{
    public interface Araba
    {
        public void Mercedes();
        public void Audi();
    }


    public class Elon : Araba
    {
        public void Audi()
        {
            Console.WriteLine("Audi A5");
        }

        public void Mercedes()
        {
            Console.WriteLine("Z7");
        }
    }



    public class Steve : Araba
    {
        public void Audi()
        {
            Console.WriteLine("Quattro 7");
        }

        public void Mercedes()
        {
            Console.WriteLine("Mercedes AMG");
        }
    }


    public class Supersport
    {
        public void AudiRx7()
        {
            Console.WriteLine("you dont never trust this car :D");
        }
        public void GTR()
        {
            Console.WriteLine("this car is so speed but is not angry");
        }
    }

    public class Adapter : Araba 
    {
        public Supersport _super;

        public Adapter(Supersport super)
        {
            _super = super;
        }



        public void Audi()
        {
            _super.AudiRx7();
        }

        public void Mercedes()
        {
            _super.GTR();
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
         
        }
    }
}
