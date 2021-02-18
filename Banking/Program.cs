using System;

namespace Banking {
    class Program {
        static void Main(string[] args) {

        var sav1 = new SavingsComposition();
        sav1.InterestRate = 0.13; // change interest rate
        sav1.Deposit(50);
        sav1.Withdraw(20);
        sav1.Withdraw(50);
        sav1.Deposit(-10);
        sav1.Withdraw(-10);
        sav1.Deposit(70);
        Console.WriteLine($"Savings balance is {sav1.Balance}");
        sav1.PayInterest(3);
        Console.WriteLine($"Savings balance is {sav1.Balance}");
    






    }
    }
}
