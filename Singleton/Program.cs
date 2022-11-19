using System;
//Adapter Patern
namespace Adapter
{
    public interface Crypt
    {
        void encrypt(string text);//Şifreleme
        void decrypt(string text);//Deşifreleme

    }

    public class CryptA : Crypt//şiferleme ve deşifreleme'yi interface ile alan sınıf
    {
        public void decrypt(string text)
        {
            Console.WriteLine("Deşifreleme");
        }

        public void encrypt(string text)
        {
            Console.WriteLine("Sifreleme");
        }
    }
    public class CryptB : Crypt//Şifreleme ve deşifrelemeyi alan sınıf
    {
        public void decrypt(string text)
        {
            Console.WriteLine("Deşifreleme");
        }

        public void encrypt(string text)
        {
            Console.WriteLine("Şİfreleme");
        }
    }

    public class Codex //Normal bir kod çözücü
    {
        public void TextToCode(string text)
        {
            Console.WriteLine("texttocode");
        }
        public void codeToText(string text)
        {
            Console.WriteLine("codetotext");
        }
    }
    public class CodeXAdapter : Crypt // şifreleme ve deşifrelemyi interface'ten alan sınıf
    {
        private Codex codex; // Codex class'ının nesnesi oluşturuldu.

        public CodeXAdapter(Codex codex)
        {
            this.codex = codex; // tetiklemek için constructor oluşturldu
        }

        public void decrypt(string text)
        {
            codex.codeToText(text);
        }

        public void encrypt(string text)
        {
            codex.codeToText(text);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
