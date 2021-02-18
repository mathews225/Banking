using System;
using System.Collections.Generic;
using System.Text;

namespace Banking {
	class SavingsComposition {
		
		public Account account { get; set; }

		public double InterestRate { get; set; } = 0.01;

		public double Interest(int months) {
			return account.Balance * (InterestRate / 12) * months;
		}


		public void PayInterest(int months) {
			var interest = Interest(months);
			Deposit(interest);
		}

		public double Balance {
			get { return account.Balance;  }
		}

		public void Deposit(double amount) {
			account.Deposit(amount);
		}

		public void Withdraw(double amount) {
			account.Withdraw(amount);
		}


		public SavingsComposition() {
			this.account = new Account("4", "Savings Account");
		}



	}
}
