using System;

namespace DependencyInversion
{

    public interface IMevzuat
    {
        public void IslemYap(Exception exception);
    }


    public class Birinci : IMevzuat
    {
        public void IslemYap(Exception exception)
        {
            Console.WriteLine("First");
        }
    }

    public class Ikinci : IMevzuat
    {
        public void IslemYap(Exception exception)
        {
            Console.WriteLine("Second");
        }
    }


    public class Ucuncu : IMevzuat
    {
        public void IslemYap(Exception exception)
        {
            Console.WriteLine("Third");
        }
    }

    public class CustomerManager
    {
        IMevzuat _mevzuat;
        public CustomerManager(IMevzuat mevzuat)
        {
            _mevzuat = mevzuat;
        }
        
        
        public void Create(Exception exception)
        {
            _mevzuat.IslemYap(exception);
        }
       
    }

   



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Birinci bir = new Birinci();
            
           
        }
    }
}
