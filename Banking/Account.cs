using System;
using System.Collections.Generic;
using System.Text;

namespace Banking {
    class Account {

        public string AcctNbr { get; set; }
        public string RoutNbr { get; set; }
        public string Description { get; set; }
        public double Balance { get; set; } = 0;

        public void Deposit(double amount) {
            if (amount > 0) {
                Balance += amount;
                Console.WriteLine($"${amount} Deposit");
                Console.WriteLine($"${Balance} Balance\n");
            }
            else {
                Console.WriteLine("Amount must be greater than $0. Did you want to withdraw instead?");
            };
        }

        public void Withdraw(double amount) {
                if (amount > 0) {
                    if (amount > Balance) {
                        Console.WriteLine($"Insufficient Funds\n");
                    }
                    else {
                        Balance -= amount;
                        Console.WriteLine($"${amount} Withdraw");
                        Console.WriteLine($"${Balance} Balance\n");
                    }
                } else {
                    Console.WriteLine("Amount must be greater than $0. Did you want to deposit instead?");
                }
        }


    }
}
