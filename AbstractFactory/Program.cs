using System;
using System.Globalization;

namespace Builderrr
{


    public class Person
    {

        private string name, surname, address;

        public Person(Builder builder)
        {
            name = builder.name;
            surname = builder.surname;
            address = builder.address;
        }

        public string getName()
        {
            return name;
        }

        public string getSurname()
        {
            return surname;
        }

        public string getAddress()
        {
            return address;
        }

        public static class Builder
        {

            private string name, surname, address;

            public Builder() { }

            public Builder name(string name)
            {
                this.name = name;
                return this;
            }

            public Builder surname(string surname)
            {
                this.surname = surname;
                return this;
            }

            public Builder address(string address)
            {
                this.address = address;
                return this;
            }

            public Company build()
            {
                return new Company(this);
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
