using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace BridgeTrying
{
    public interface Empolyees
    {
        public void Name();
        public void Surname(string surname);

        public void Salary();

    }



    public class Human : Empolyees
    {
        //Bu Sayede aslına bakarssanız implemenatasyon zorunlu hale getirilen class'lar.kullanılmalıdır.
        //Ancak canlı olmaayan işçileri için kullanılmayabilirler
        public void Name()
        {
            Console.WriteLine("Necessary");
        }

        public void Salary()
        {
            Console.WriteLine("Necessary");
        }

        public void Surname(string surname)
        {
            Console.WriteLine("Necessary");
        }
    }

    public abstract class Bridge
    {
        private Empolyees _emp;

        protected Bridge(Empolyees emp)
        {
            _emp = emp;
        }

        public void İsim()
        {
            _emp.Name();
        }
        public void Soyisim(string surname)
        {
            _emp.Surname(surname);
        }
        public void Maas()
        {
            _emp.Salary();
        }



    }


    public class Humans : Bridge
    {
        public Humans(Empolyees emp) : base(emp)
        {
        }

        public void deneme(string deneme)
        {
            Soyisim(deneme);

        }

        //Şekinde yazılabilmektedir.
    }


    public class Robots
    {

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
