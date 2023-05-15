using System.Threading.Channels;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();
            P1.SetfirstName("shrooq");
            P1.SetlastName("said");
            P1.Setage(1997);
            P1.Setsalary(900);
            Console.WriteLine(P1.printInfo());


           //BanckAccount
           BankAccount B1 = new BankAccount();
            B1.SetAccount_Number(56789);
            B1.SetBalance(2000);
            Console.WriteLine( $"Your Balance{B1.deposite }");
            B1.writedrae(60);








        }
    }
}