namespace MltiDelegent
{

    public delegate void Rectangle(double width, double length);
    internal class Program
    {
        static void Main(string[] args)
        {
            RectangleleHelp rec1 = new RectangleleHelp();
            Rectangle rec = new Rectangle (rec1.getArea );
            rec += rec1.getArea;
            rec += rec1.Add ;
            rec += rec1.SUP ;
            rec += rec1.Div ;

            rec(10, 12);

            
        }
    }








    class RectangleleHelp
    {
        public double width { get; set; }
        public double height { get; set; }  
        public void getArea(double width, double height) 
        {

            Console.WriteLine($"The Area is {width *height }");
        }

        public void Add(double width, double height)
        {

            Console.WriteLine($"The Sum is : {width + height}");
        }

        public void SUP(double width, double height)
        {

            Console.WriteLine($"The SUP is: {width - height}");
        }

        public void getPerimeter(double width, double height)
        {

            Console.WriteLine($"The Perimeter is : {2*(width * height)}");
        }

        public void Div(double width, double height)
        {

            Console.WriteLine($"The Div is : {width / height}");
        }








    }




}