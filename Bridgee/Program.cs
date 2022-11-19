using System;

namespace Bridgee
{
   public interface Bridge
    {
        public string OperationTmp();

    }

    public class ImplementationA : Bridge
    {
        public string OperationTmp()
        {
            return "Implementation A";

        }
    }

    public class ImplemetaitonB : Bridge
    {
        public string OperationTmp()
        {
            return "Implemetation B";
        }
    }


   public class Abstraciton
    {
        Bridge _bridge;

        public Abstraciton(Bridge bridge)
        {
            _bridge = bridge;
        }

        public string Operation()
        {
            return "Abstraction <>" + _bridge.OperationTmp();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bridge Pattern \n");
            Console.WriteLine(new Abstraciton(new ImplementationA()).Operation());
            Console.WriteLine(new Abstraciton(new ImplemetaitonB()).Operation());

        }
    }
}
