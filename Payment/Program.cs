using System.Drawing;

namespace Payment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Casher cash = new Casher(new cash(56.34m));
            Casher cash1 = new Casher(new Visa(45.6m));
            Casher cash2 = new Casher(new MasterdCard(12.23m));


            cash.checkout();
            cash1.checkout();   
            cash2.checkout();   


        }
    }


    interface Ipayment
    {
        void pay();
    }
    class Casher
    {
        public Ipayment payment;
        public Casher(Ipayment payment)
        {
            this.payment = payment;
        }
        public void checkout() {
            payment.pay();
        }

    }

    class cash : Ipayment
    {
        public decimal amount { get; set; }
        public cash(decimal amount)
        {
            this.amount = amount;
        }
        public void pay()
        {
            Console.WriteLine("cash");
        }
    }

    class Visa : Ipayment
    {
        public decimal amount { get; set; }
        public Visa(decimal amount)
        {
            this.amount = amount;
        }
         public void pay()
        {
            Console.WriteLine("visa");
        }


    }

    class MasterdCard : Ipayment
    {
        public decimal amount { get; set; }
        public MasterdCard(decimal amount)
        {
            this.amount = amount;
        }
        public void pay()
        {
            Console.WriteLine("Mastercard");
        }


    }
}