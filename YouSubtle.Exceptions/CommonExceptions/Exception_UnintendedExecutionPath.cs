using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouSubtle
{
	public class Exception_UnintendedExecutionPath : Exception
	{
		public Exception_UnintendedExecutionPath()
		{

		}

		public Exception_UnintendedExecutionPath(string message):
		base(message)
		{

		}
	}
}
