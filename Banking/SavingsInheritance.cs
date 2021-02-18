using System;
using System.Collections.Generic;
using System.Text;

namespace Banking {
	class SavingsInheritance : Account {

		public double InterestRate { get; set; } = 0.12;

		public SavingsInheritance() : base() { }

		public SavingsInheritance(string AcctNbr, string Desc) : base(AcctNbr, Desc) { }

		public SavingsInheritance(string AcctNbr, double IntRate) : base (AcctNbr, "New Savings Account") {
			this.InterestRate = IntRate;
		}

	}
}
