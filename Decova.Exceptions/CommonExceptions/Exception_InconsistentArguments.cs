using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decova
{
	public class Exception_InconsistentArguments : ArgumentException
	{
		private Exception_InconsistentArguments()
		: base()
		{
			
		}

		private Exception_InconsistentArguments(string message)
		: base(message)
		{
			
		}

		private Exception_InconsistentArguments(string message, Exception innerException)
		: base(message, innerException)
		{
			
		}

		public string[] InconsistentArguments { get; private set; }

		public static Exception_InconsistentArguments New(string moreExplanation=null, params string[] inconsistentParams)
		{
			StringBuilder message = new StringBuilder($"The following supplied arguments are not consistent [{String.Join(",", inconsistentParams)}].");
			message.Append(moreExplanation);
			var expt = new Exception_InconsistentArguments(message.ToString())
			{
				InconsistentArguments = inconsistentParams
			};

			return expt;
		}
	}
}
