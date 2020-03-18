using System;
using System.Collections.Generic;
using System.Text;

namespace Decova
{
    public static class ExceptionExtension
	{
		public static Exception GetNestedExceptionOfType<T>(this Exception This)
		{
			Exception stepException = This.InnerException;
			while (stepException != null)
			{
				if (stepException.GetType() == typeof(T))
				{
					return stepException;
				}

				stepException = stepException.InnerException;
			}
			

			return null;
		}

		public static bool HasNestedExceptionOfType<T>(this Exception This)
		{
			return GetNestedExceptionOfType<T>(This) != null;
		}

		public static Exception GetRootException(this Exception This)
		{
			Exception stepException = This;
			while(true)
			{
				if (stepException.InnerException == null)
				{
					return stepException;
				}
				stepException = This.InnerException;
			}
		}

		public static Exception SkipTargetOfInvocation(this Exception surfaceExpt)
		{
			while (surfaceExpt is System.Reflection.TargetInvocationException)
			{
				surfaceExpt = surfaceExpt.InnerException;
			}
			
			return surfaceExpt;
		}

        
    }
}
