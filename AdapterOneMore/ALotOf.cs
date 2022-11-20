using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterOneMore
{
    public interface BottleWater
    {
        public void Munzur();
        public void Cesme();
    }


    public class President : BottleWater
    {
        public void Cesme()
        {
            Console.WriteLine("O bu sudan nefret eder çünkü o bir müslüman,ve müslümanlar rakı içmez");
        }

        public void Munzur()
        {
            Console.WriteLine("O bu suya bayılırm mmhh");
        }
    }


    public class Citizen : BottleWater
    {
        public void Cesme()
        {
            Console.WriteLine("Onlar buna bayılırlar neredeyse hepsinin gözleri bunu arar");
        }

        public void Munzur()
        {
            Console.WriteLine("Tanrının suyunuda parayla satmazsınız ki bre kafirler");
        }
    }

    public class ThisGod
    {
        public void Paradise()
        {
            Console.WriteLine("Çeşme suyu neyine yetmedi bre kaf,de get az ötede oyna");
        }

        public void Hell()
        {
            Console.WriteLine("Çeşme değil terkos");
        }
    }


    public class Cosmos : BottleWater
    {
        ThisGod _thisGod;  //şşş private

        public Cosmos(ThisGod thisGod)
        {
            _thisGod = thisGod;
        }

        public void Cesme()
        {
            _thisGod.Hell();
        }

        public void Munzur()
        {
            _thisGod.Paradise();
        }
    }

}
