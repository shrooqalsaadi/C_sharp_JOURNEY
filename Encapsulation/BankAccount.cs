using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public  class BankAccount
    {
        private const decimal MAX = 800;
        private decimal  Balance; 
        private int Account_Number;

     public void SetAccount_Number(int Account_Number)
        {
            this.Account_Number = Account_Number;

        }
        public int GetAccount_Number()
        {
            return Account_Number;

        }


        public void SetBalance(decimal  Balance)
        {

            this.Balance = Balance;


        }
        public decimal  GetBalance()
        {

            return Balance;


        }
        public decimal deposite(decimal amount)
        {

            Balance =  Balance +amount;
            return Balance; 
        }
        public decimal writedrae(decimal amount)
        {

            if (amount > MAX)
            {
                Console.WriteLine( "check your Balance:");

            }
            else if(amount>Balance ) 
            {
                Console.WriteLine("Your Balnce is too low go to home :");
            }
            else
            {
                Balance =Balance-amount;
                Console.WriteLine($"your amount is :{Balance}");

            }
            return Balance;
        }







    }
}

