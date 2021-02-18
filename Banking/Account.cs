using System;
using System.Collections.Generic;
using System.Text;
using Banking.Exceptions;

namespace Banking {
  class Account {
    public string AcctNbr { get; private set; }
    public string Description { get; set; }
    public double Balance { get; private set; } = 0;



    public void Deposit(double amount) {
      if (amount > 0) {
        Balance += amount;
        Console.WriteLine($"Deposit: ${amount}");
        Console.WriteLine($"Balance: ${Balance}\n");
      } else {
        Console.WriteLine("-- Deposit Denied --\nERROR: Negative Amount Entered\n");
      };
    }

    public void Withdraw(double amount) {
      if (amount > 0) {
        if (amount > Balance) {
          Console.WriteLine($"-- Withdraw Denied --\nERROR: Insufficient Funds\n");
        }
        else {
          Balance -= amount;
          Console.WriteLine($"Withdraw: ${amount}");
          Console.WriteLine($"Balance: ${Balance}\n");
        }
      } else {
        throw new InsignificantFundsException(Balance, amount);
      }
    }

    public Account() : this("DefAcct0", "Default Description") { }

    public Account(string acctNbr, string desc = "New Account") {
      AcctNbr = acctNbr;
      Description = desc;
    }

  }
}
