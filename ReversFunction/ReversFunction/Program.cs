using System.Linq;


namespace ReversFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>() { 2, 4, 7, 9, 10 };

            //Way 1 ...

            var r = lst.Where(i => i % 2 == 0);
            foreach (var item in r)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");

            //Way 2

            var res = from i in lst
                      where i % 2 == 0
                      select i;
            foreach (var item in res)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("");

        }

        //    {
        //        int s = 258;
        //        int j = s.miroor();
        //        Console.WriteLine(j);
        //    }
        //}


    }
}
