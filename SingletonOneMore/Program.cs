using System;

namespace SingletonOneMore
{
    //public,private,public,public


    public class AObject
    {
        private static AObject instance;

        public AObject()
        {

        }

       public static AObject Trying()
        {
            if (instance == null)
            {
                instance = new AObject();   
            }
            return instance;
        }
    }



    public class BObject
    {
        private static BObject instance;
        public BObject()
        {

        }
        public static BObject Trying()
        {
            if (instance == null)
            {
                instance = new BObject();
            }
            return instance;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AObject instance = AObject.Trying();
            AObject instance2 = AObject.Trying();
            AObject instance3 = AObject.Trying();
            AObject Try = AObject.Trying();

            BObject instance4 = BObject.Trying();



            if (instance.Equals(instance2))
            {
                Console.WriteLine("this object is same");
            }
            else
            {
                Console.WriteLine("this object is different,ım sorry :(");

            }


            if (instance2.Equals(instance4))
            {
                Console.WriteLine("objects are same");
            }
            else
            {
                Console.WriteLine("objects ara different");
            }

        }
    }
}
