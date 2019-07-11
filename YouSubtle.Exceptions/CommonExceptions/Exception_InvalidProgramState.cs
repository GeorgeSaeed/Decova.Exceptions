using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouSubtle
{
	public class Exception_InvalidProgramState : Exception
	{
		public Exception_InvalidProgramState()
		:base()
		{
			
		}

		public Exception_InvalidProgramState(string message)
		:base(message)
		{

		}

		public Exception_InvalidProgramState(IReadOnlyCollection<IReadOnlyCollection<string>> disturbanceLog, string message)
		:base(message)
		{
			
		}

		public Exception_InvalidProgramState(IReadOnlyCollection<IReadOnlyCollection<string>> disturbanceLog, string message, Exception innerException)
		:base(message, innerException)
		{
			
		}

	}
}
