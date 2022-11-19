using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;


//Anlaşılacağı üzere genellikle oyunlarda kullanılan bir yapıdır.Araba üzerinden örnek verilecek olursa,
//Arabaalar her defasında spawn olurken IClonaeable gibi interface yada fonksiyonlar kullanmaktadr.
//Gereklilikler yerine getirilyorsa yeni araba oluşturulacaktır ancak boolean değer false dönerse try catch il hata fırlatma gerçekleştirilecektir.
namespace PRototypeee
{
    public class Soldier : ICloneable
    {
        private int health;
        private int speed;
        private int maxLifeTime;
        private int agility;
        private int power;
        private int rank;

        private string weapon;

        private bool isAvailableForWar;

        public Soldier(int health, int speed, int maxLifeTime, int agility, int power, int rank, string weapon, bool isAvailableForWar)
        {
            this.health = health;
            this.speed = speed;
            this.maxLifeTime = maxLifeTime;
            this.agility = agility;
            this.power = power;
            this.rank = rank;
            this.weapon = weapon;
            this.isAvailableForWar = isAvailableForWar;

            if (isAvailableForWar)
            {
                Console.WriteLine("Ready for war");
            }
            else
            {
                Console.WriteLine("this soldier not ready for war");
            }


            
        }

        public Soldier Clone()
        {
            Soldier soldier = null;
            try
            {
                soldier = (Soldier)ISimpleTransactionSuperior.ReferenceEquals();

            }
            catch (Exception)
            {

                Console.WriteLine("Soldier copied moment one exception");
            }
            return soldier;
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
