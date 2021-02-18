using System;
using Banking.Exceptions;

namespace Banking {
    class Program {
        static void Main(string[] args) {

        var sav1 = new SavingsInheritance();
        sav1.InterestRate = 0.13; // change interest rate
        sav1.Deposit(50);
        sav1.Withdraw(20);
			try {
        sav1.Withdraw(50);

			}
			catch (InsignificantFundsException ifEx) {
				Console.WriteLine(ifEx.Message);
        return;
			}
        sav1.Deposit(-10);
        sav1.Withdraw(-10);
        sav1.Deposit(70);
        Console.WriteLine($"Savings balance is {sav1.Balance}\n");
        sav1.PayInterest(3);
    






    }
    }
}
