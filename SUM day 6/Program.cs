using System;
using System.Runtime.CompilerServices;

namespace SUM_day_6
{
    internal class Program
    {
        //method 
        public static void printLine()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("#");

            }
            Console.WriteLine();

        }
        public static void printLi(int cnt = 4, string Pattern = "##")
        {
            for (int i = 0; i <= cnt; i++)
            {
                Console.Write(Pattern);
            }
            Console.WriteLine();

        }
        public static void Sum(int x , int y, out int s , out int M )
//Sum
        {
            s = x + y;
            M = x*y;  
        }

        //swap method
        //without ref will not be excute
        //by value : read only
        //by ref : read and write
        public static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void sum(int x, int y, out int s, out int m)
        {
            s = x + y;
            m = x * y;


        }





        static void Main(string[] args )
        {
            int a = 3, b=5, sresult , mm;
                Sum(a, b , out sresult, out mm);
            Console.WriteLine($" sum {sresult}");
            Console.WriteLine($"Multiblication {mm}");
        

        // calculator

        calculator calculator = new calculator();
        int a1 =10, b2 =15;
        double c = 10.4, d = 15.3;
        string f = "hello", e = "three";
            Console.WriteLine(calculator.add(a1, b2));
            Console.WriteLine(calculator.add(c, d));
            Console.WriteLine(calculator.add(f, e));

        }






        person P1 = new person(1, "shrooq", "said", 25, "software Engenering", "suwaiq", true);

        















    }



}