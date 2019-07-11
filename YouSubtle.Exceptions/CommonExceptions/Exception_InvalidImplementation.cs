using System;
using System.Collections.Generic;
using System.Text;

namespace YouSubtle
{
    public class Exception_InvalidImplementation : Exception
    {
		public Exception_InvalidImplementation()
		{

		}

		public Exception_InvalidImplementation(string message)
		:base(message)
		{

		}
	}
}
