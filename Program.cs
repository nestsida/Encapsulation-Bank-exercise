using System;

namespace BankEncapsulation_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();
            Console.WriteLine("How much do you want to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());
            
            ba.Deposit(amountToDeposit);
            double userBalance = ba.GetBalance();

        }
    }
}
