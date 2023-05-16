namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name= "Nroo"; 
            Dog dog = new Dog();
            Egale egale = new Egale();
            Console.WriteLine(cat);
        }
    }
}