using System;

namespace SampleConApp
{
    abstract class Account
    {
        public int AccountNo { get; set; }
        public string AccountHolder { get; set; }
        public long ContactNo { get; set; }
        public void Credit(int amount)
        {
            Balance += amount;
        }

        public void Debit(int amount)
        {
            if (amount > Balance)
                throw new Exception("Insufficient funds");
            Balance -= amount;
        }

        public double Balance { get; private set; }
        public abstract void CalculateInterest();
       
    }

    class SBAccount : Account
    {
        public override void CalculateInterest()
        {
            double interest = Balance * 1 / 12 * 6.5 / 100;
            Credit((int)interest);
        }
    }
    
    class AbstractClasses
    {
        static Account acc = null;
        static void Main(string[] args)
        {
            acc = new SBAccount();
            acc.AccountNo = 12323;
            acc.AccountHolder = "Phaniraj";
            acc.ContactNo = 2342343434;
            acc.Credit(34000);
            acc.CalculateInterest();
            Console.WriteLine("The Balance of this Account is " + acc.Balance);
        }
    }
}
