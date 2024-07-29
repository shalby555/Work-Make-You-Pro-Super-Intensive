using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Make_You_Pro
{
	public static class Variables
	{
	 public static int CalculationOfCourierDelivery (int a, int b, int c)
		{
			int result = a * c + b;
			return result;
		}
		public static int BankDepositeRates(int a)
		{
			double b = a; int c = a;
			a = a * 8 / 100 * 9;
		    b = a * 9.5 / 100 * 12;
		    c = a * 10 / 100 * 18;
			
			return a;return b;return c;
		} 
	}
	
}
