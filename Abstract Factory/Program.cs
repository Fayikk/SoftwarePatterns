using System;

namespace Abstract_Factory
{

    public abstract class Connection
    {
        public abstract bool Connect();
        public abstract bool Disconnect();
        public abstract string State { get; };   
    }

    public abstract class Command
    {
        public abstract void Execute(string query); 
    }

    public class Db2Connection : Connection
    {
        public override string State { get { return "Open"; } }

        public override bool Connect()
        {
            Console.WriteLine("Db2 bağlantısı açılacak");
            return true;
        }

        public override bool Disconnect()
        {
           Console.WriteLine("DB2  bağlantısı kapatılacak");
            return true;
        }
    }

    public class Db2Command : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("Db2 sorgusu çalıştıırıle-r");
        }
    }


    public class InterbaseCommand : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("Interbase Command sorgusu çalıştırılır");
        }
    }


    //İstemicinim ihtiyaç ürünlerini üretilmesi

    public abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }

    public class Db2Factory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new InterbaseCommand();
        }

        public override Connection CreateConnection()
        {
            //return new InterbaseConnection();

            return new InterbaseConnection();
        }
    }


    public class Factory
    {
        private DatabaseFactory _databaseFactory;
        private Connection _connection;
        private Command _command;

        public Factory(DatabaseFactory databaseFactory, Connection connection, Command command)
        {
            _databaseFactory = databaseFactory;
            _connection = connection;
            _command = command;
        }
    
    
        public void Start()
        {
            _connection.Connect();
            if (_connection.State == "Baglanti Durumu")
            {
                _command.Execute(".......Select");
            }
        }
    
    
    
    }





    public class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
