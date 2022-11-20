using System;

namespace Bridgeee
{
    public interface ITv //Gerekli interface oluşturuldu
    {
        public void On();
        public void Off();
        public void SwitchChannel(int channel);
    }


    public class Samsung : ITv //Procust tarafından zorunlu hale getirilen metodlar
    {

        public void Off()
        {
            Console.WriteLine("System Closed");
        }

        public void On()
        {
            Console.WriteLine("System Opened");
        }

        public void SwitchChannel(int channel)
        {
            Console.WriteLine("Channel Switched");
        }
    }


    public class SonyTv : ITv //Sony tarafından zorunlu hale getirilen metodlar
    {
        public void Off()
        {
            Console.WriteLine("Channel is closed");
        }

        public void On()
        {
            Console.WriteLine("Channel is Opened");
        }

        public void SwitchChannel(int channel)
        {
            Console.WriteLine("Channel is switched");
        }
    }

   //-----------------------------------
   public abstract class AbstractRemoteControl  // Abstract class 
        //Hatırla İntefaceler gibi barındırdığı metod vb override etmek zorunlu değildir.İmplementasyonunu sağlaayan class'lar için
    {
        private ITv tv; //İnterface newlenemez,ancak nesnesi oluşturulabilir.

        protected AbstractRemoteControl(ITv tv)
        {
            this.tv = tv; //Dependency injection ile bağımlılıklarımızda kutulduk 
        }

        public void TurOn()
        {
            tv.On();    
        }

        public void TurnOff()
        {
            tv.Off();
        }

        public void Switch(int channel)
        {
            tv.SwitchChannel(channel);
        }
    }


    public class LogitechRemoteControl : AbstractRemoteControl
    {
        public LogitechRemoteControl(ITv tv) : base(tv)
        {
        }

        //Abstract class'ı kullanarak direk olarak interface ile iletiişme geçmemi olduki
        //Dolayasıyla override edilen gereklilikler kullanılmak zorunda değillerdirç

        public void SetChannel(int channel)
        {
            SetChannel(channel);
            Console.WriteLine("Channel is switched");
        }
    }




    public class Program
    {
        static void Main(string[] args)
        {
            ITv TV = new SonyTv();

            LogitechRemoteControl lrc = new LogitechRemoteControl();
            
        }
    }
}
