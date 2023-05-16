using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Vechile
    {
        public int id;
        public string name;
        public string description;
      
      public Vechile (int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
    }



    class honda:Vechile
    {
        public int YearefMan;
        public honda(int id, string name, string description, int YearefMan):base (id,name,description) 
        {
            this.YearefMan= YearefMan;
        }
    }
    interface Iloader
    {
        void Load ();
        void inload();
    }
     interface Idrive
    {
        void start ();
        void stop ();
    }
    class caterpiler:Vechile, Iloader , Idrive
    {
        public caterpiler (int id,string name,string description):base (id,name,description)
        {

        }

        public void inload()
        {
            Console.WriteLine("in load"); 
        }

        public void Load()
        {
            Console.WriteLine("load");
        }

        public void start()
        {
            Console.WriteLine("Start");
        }

        public void stop()
        {
            Console.WriteLine("stop"); ;
        }
    }

}
