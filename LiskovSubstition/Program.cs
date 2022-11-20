using System;

namespace LiskovSubstition
{
    //Alt sınıfın nesneleri,üst sınfın nesneleri ile yer değiştirdikten sonra aynı davranışı göstermnek zorundadırlar.
    //Dolayısıyla o zaman yapılması gereken hareketlerden biri şudur.
    
    public abstract class Keep
    {
        public virtual void KeepTheBall()
        {
            Console.WriteLine("anything");
        }
    }
    public interface kick
    {
        public void KickTheBall();
    }

    //Kaleci keep ve kick edebilir ancak,
    //Oyuncu kick edebilirken keep edemez;

    public class Player : kick
    {
        public void KickTheBall()
        {
            Console.WriteLine("player can kick the ball");
        }
    }

    public class GoalKeeper : Keep, kick
    {
        public void KickTheBall()
        {
            Console.WriteLine("Goalkeeper can kick yhe ball");
        }

        public virtual void KeepTheBall()
        {
            Console.WriteLine("Goalkeeper can keep the ball");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


//Şeklinde yazılabilmektedir.
//Liskov substition prensibi.