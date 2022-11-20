using System;

namespace Bridge
{
    public interface HumanBehaviour
    {
        public void Good();
        public void Bad();
        public void Query(string rule);

    }


    public class Student : HumanBehaviour
    {
        public void Bad()
        {
            Console.WriteLine("I like girls,smoke,drugs and show crazy behaviour");
        }

        public void Good()
        {
            Console.WriteLine("I just good,ı laugh everywhere and everyone,bcs ı'm not stronger");
        }

        public void Query(string rule)
        {
            Console.WriteLine("if ı want exchange world and human sociology bcs ı'm take my brain,it is enough" + rule);
        }
    }


    public class Teacher : HumanBehaviour
    {
        public void Bad()
        {
            Console.WriteLine("Im never learning,ı'm always same place here");
        }

        public void Good()
        {
            Console.WriteLine("I give candy for my class,and they re said good for me :)");
        }

        public void Query(string rule)
        {
            Console.WriteLine("I'm a real teacher,ı'm not emotional thinking,I always ready for guestion and answer,you just listen to me in lesson" + rule);
        }
    }


    public abstract class Philosophy
    {
        HumanBehaviour behaviour;

        public Philosophy(HumanBehaviour behaviour)
        {
            this.behaviour = behaviour;
        }

        public void Happy(string rule)
        {
            behaviour.Query(rule);
        }

        public void Sad()
        {
            behaviour.Bad();
        }

        public void mediocrity()
        {
            behaviour.Good();
        }
    }


    public class NormalPerson : Philosophy
    {
      
        public void BeHuman(string rule)
        {
            Happy(rule);
        }

        public void NotBeHuman()
        {
            Sad();
        }

        public void Creeper()
        {
            mediocrity();
        }
    }



    public class Program
    {
        static void Main(string[] args)
        {

            
        }
    }

}
