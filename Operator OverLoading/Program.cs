using System.Numerics;

namespace Operator_OverLoading
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            Money m1= new Money (2);
            Money m2= new Money (5);
            Money m3= m1+m2;
            Money m4 = m1 * m2;
            Money m5 = m1 / m2;
            Console.WriteLine(m3.amount);
            Console.WriteLine(m4.amount);
            Console.WriteLine(m5.amount);   

        }
    }




   
    public class Money
    {

       public  decimal amount;
       

        public Money(decimal amount)
        {
            this.amount = amount;
        }

        public static  Money operator +(Money M1 , Money M2) 
        {

            decimal value= M1.amount + M2.amount;

            return new Money (value);
        }

        public static Money operator *(Money M1, Money M2)
        {

            decimal value = M1.amount * M2.amount;

            return new Money(value);


        }

        public static Money operator /(Money M1, Money M2)
        {

            decimal value = M1.amount / M2.amount;

            return new Money(value);


        }
    }
}