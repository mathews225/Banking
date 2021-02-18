using System;
using System.Collections.Generic;
using System.Text;

namespace Banking {
  class Account {
    public string AcctNbr { get; private set; }
    public string Description { get; set; }
    public double Balance { get; private set; } = 0;



    public void Deposit(double amount) {
      if (amount > 0) {
        Balance += amount;
        Console.WriteLine($"${amount} Deposit");
        Console.WriteLine($"${Balance} Balance\n");
      } else {
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

    public Account() : this("DefAcct0", "Default Description") { }

    public Account(string acctNbr, string desc = "New Account") {
      AcctNbr = acctNbr;
      Description = desc;
    }

  }
}
