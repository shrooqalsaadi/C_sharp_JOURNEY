namespace OOP_ASS
{
    internal class Program
    {
        static void Main(string[] args)

        {

            //Q1>>>
           Rectangle rec = new Rectangle();
            rec.area_rectangle();
            Console.WriteLine();
            Console.WriteLine(rec.area(4.5, 3.1));    
            Console.WriteLine(rec.area(4, 3));





            //Q2>>
            Calculator cal = new Calculator();
            Console.WriteLine("sum of 2 integers");
            Console.WriteLine(cal.Add( 1, 2));
            Console.WriteLine("sum of 3 integers");
            Console.WriteLine(cal.Add(5, 6, 7));



            //Q3>>
            Person p1 = new Person("shrooq", 25);
            Person p2 = new Person("shrooq", 25, 2);



            //Q4>>>
            Product prod = new Product();


            //Q5>>
            






        }
    }
}
