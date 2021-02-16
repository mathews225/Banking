using System;

namespace Banking {
    class Program {
        static void Main(string[] args) {
            var acct1 = new Account();
            acct1.AcctNbr = "100";
            acct1.Deposit(200);
            acct1.Withdraw(30);
            acct1.Withdraw(-200);
            Console.WriteLine($"Current account balance is ${acct1.Balance}.");


        }
    }
}
