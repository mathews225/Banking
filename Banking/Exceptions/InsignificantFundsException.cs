using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Exceptions {

	public class InsignificantFundsException : Exception {

		public double AcctBalance { get; set; }
		public double WithdrawAmt { get; set; }

		public InsignificantFundsException(double balance, double amount)
			: base($"Current Balance is ${balance}, withdrawing ${amount}.\n") {
			AcctBalance = balance;
			WithdrawAmt = amount;
		}


		public InsignificantFundsException() 
			: base() { }
		public InsignificantFundsException(string Message) 
			: base(Message) { }
		public InsignificantFundsException(string Message, Exception InnerException)
			: base(Message, InnerException) { }
	} 



}
//		public MyException() { }
//		public MyException(string message) : base(message) { }
//		public MyException(string message, Exception inner) : base(message, inner) { }
//		protected MyException(
//		System.Runtime.Serialization.SerializationInfo info,
//		System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
//	} {

//	}
//}
