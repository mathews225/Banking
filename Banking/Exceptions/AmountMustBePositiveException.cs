using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Exceptions {
	class AmountMustBePositiveException : Exception {
		public AmountMustBePositiveException() { }
		public AmountMustBePositiveException(string message) : base(message) { }
		public AmountMustBePositiveException(string message, Exception inner) : base(message, inner) { }
		
	}
}
