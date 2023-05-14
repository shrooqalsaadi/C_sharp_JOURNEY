using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASS
{
    internal class Person
    {

        public string Name;
        public int Age;
        public int time;    
        public Person(string Name1, int Age) 
        {
        this.Name = Name1;
        this.Age = Age;
            Console.WriteLine($"Your name is { Name } and your Age is {Age} ");
        }
        public Person(string Name1, int Age1, int time)
        {
            this.Name = Name1;  
            this.Age = Age1; 
            this.time = time;
            for (int i = 0; i < time; i++) ;
            {

                Console.WriteLine($"Your name is {Name} and your Age is {Age} ");
            }
            
        }




    }
}
