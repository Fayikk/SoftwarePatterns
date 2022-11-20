using System;

namespace Open_ClosedPrinciple
{
    //Open Closed principle'a göre her class geliştirmeye açık olmalı fakat değişime kapalı olmalıdır.

    public abstract class File
    {
        public abstract void SaveToFile(string text);
    }

    public class TxtFile : File
    {
        public override void SaveToFile(string text)
        {
            Console.WriteLine("This method for write Txt File" + text);
        }
    }

    public class XlsFile : File
    {
        public override void SaveToFile(string text)
        {
            Console.WriteLine("This method for write xls file" + text);
        }
    }


    //Yukarıda görüldüğü üzere abstract class'ı değiştirmiyoruz tada diğer class'ların içieriği aynı olacak şekilde kalmaktadır.
    //Ancak farklı zamanlarda dosya yazma işlemlerinde,farklı bir durum ortaya çıkarsa o zaman bu
    //Class'ların arasına daha farklı bir dosya işlemi getirilirse,yeni class'lar eklenecektir.



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
