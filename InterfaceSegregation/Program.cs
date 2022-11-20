using System;

namespace InterfaceSegregation
{
    //Tüm interface'lerin tek bir işi olmalıdır.
    //Bütün metodları kapsayan interface yazmak yerine,her iş için ayrı interface'ler yazmamız daha doğru bir yaklaşımdır. 



    public interface IMercedeRepository
    {
        public void Model();
        public void ModelYear();
        public void DailyPrice();
    }

    public interface IAudiRepository
    {
        public void Model();
        public void ModelYear();
        public void DailyPrice();
    }


    public class Mercedes : IMercedeRepository
    {
        public void DailyPrice()
        {
            throw new NotImplementedException();
        }

        public void Model()
        {
            throw new NotImplementedException();
        }

        public void ModelYear()
        {
            throw new NotImplementedException();
        }
    }


    public class Audi : IAudiRepository
    {
        public void DailyPrice()
        {
            throw new NotImplementedException();
        }

        public void Model()
        {
            throw new NotImplementedException();
        }

        public void ModelYear()
        {
            throw new NotImplementedException();
        }
    }

    //Şeklinde yazılıp içleri doldurulabilir hale getirilmelidir.

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
