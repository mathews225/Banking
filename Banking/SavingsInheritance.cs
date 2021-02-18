using System;
using System.Collections.Generic;
using System.Text;

namespace Banking {
	class SavingsInheritance : Account {

		public double InterestRate { get; set; } = 0.12;

		public void PayInterest(int months) {
			var interest = Balance * (InterestRate / 12) * months;
			Deposit(interest);
			Console.WriteLine($"-- Interest Paid --\n{months} months at {InterestRate}% on ${Balance-interest}\nNew Balance: ${Balance}");
		}

		public SavingsInheritance() : base() { }

		public SavingsInheritance(string AcctNbr, string Desc) : base(AcctNbr, Desc) { }

		public SavingsInheritance(string AcctNbr, double IntRate) : base (AcctNbr, "New Savings Account") {
			this.InterestRate = IntRate;
		}

	}
}
