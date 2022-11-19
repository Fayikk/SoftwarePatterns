using System;

namespace Builder
{
    public class Ev
    {
        private string il;
        private string ilce;
        private string mahalle;

        private int binaYili;
        private int odaSayisi;
        private int banyoSayisi;
        private int tuvaletSayisi;
        private int balkonSayisi;

        private bool isDublex;
        private bool isEsyali;
        private bool hasOtopark;
        private bool hasCocukParki;
        private bool hasKlima;
        private bool hasHavuz;


        public Ev()
        {

        }
        public Ev(string il, string ilce, string mahalle, int binaYili, int odaSayisi, int banyoSayisi, int tuvaletSayisi, int balkonSayisi, bool isDublex, bool isEsyali, bool hasOtopark, bool hasCocukParki, bool hasKlima, bool hasHavuz)
        {
            this.il = il;
            this.ilce = ilce;
            this.mahalle = mahalle;
            this.binaYili = binaYili;
            this.odaSayisi = odaSayisi;
            this.banyoSayisi = banyoSayisi;
            this.tuvaletSayisi = tuvaletSayisi;
            this.balkonSayisi = balkonSayisi;
            this.isDublex = isDublex;
            this.isEsyali = isEsyali;
            this.hasOtopark = hasOtopark;
            this.hasCocukParki = hasCocukParki;
            this.hasKlima = hasKlima;
            this.hasHavuz = hasHavuz;

        }

        public string Il { get ; set ; }
        public string Ilce { get ; set; }
        public string Mahalle1 { get ; set ; }
        public int BinaYili { get ; set ; }
        public int OdaSayisi { get ; set ; }
        public int BanyoSayisi { get ; set ; }
        public int TuvaletSayisi { get ; set ; }
        public int BalkonSayisi { get ; set ; }
        public bool IsDublex { get; set ; }
        public bool IsEsyali { get ; set ; }
        public bool HasOtopark { get ; set; }
        public bool HasCocukParki { get ; set ; }
        public bool HasKlima { get ; set ; }
        public bool HasHavuz { get ; set; }
    }

    public class Emlakci
    {
        public  void printEv(Ev ev)
        {
            Console.WriteLine();
            Console.WriteLine("Ev Eklendi -> " + ev.Il);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Ev ev1 = new Ev();
            Console.WriteLine("Hello World!");
            ev1.Il = "Diyarbakir";
            ev1.Ilce = "Yenisehir";
            ev1.Mahalle1 = "Toki";
            ev1.OdaSayisi = 3;
            ev1.HasKlima = true;

            Ev ev2 = new Ev { Il = "Kocaeli", Ilce = "Yuvacık", Mahalle1 = "Nebilem", OdaSayisi = 3, HasKlima = true, HasOtopark = true, HasHavuz = false };


            Emlakci emlak = new Emlakci();
            emlak.printEv(ev2);
            emlak.printEv(ev1);


        }
    }
}
