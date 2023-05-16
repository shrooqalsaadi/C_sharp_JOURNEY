using Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Animal
{
    public abstract class animal//perant class
    {
        public  string Name;
        int age;
        public virtual void  move()
        {
            Console.WriteLine("Moving");
        }
        //Abstracted+body 
        public abstract void makeSound();
    }


   public  class Egale : animal { 
    public string grnder;
    
        string gender;
        public override void makeSound()
        {
            Console.WriteLine("I can Flay");
        }
    }



    public class Cat : animal {
        public string gender;

        public override void makeSound()
        {
            Console.WriteLine("meawooooo");
        }
        public override void move()
        {
            base.move();
            Console.WriteLine("Four lege");
        }
        public override string ToString()
        {
            return $"My Name is :{this.Name}"; 
        }
    }

        public class Dog : animal {
            public string catogry;
            public override void makeSound()

            {
                Console.WriteLine("woooohwh");
            }





        }
    }


