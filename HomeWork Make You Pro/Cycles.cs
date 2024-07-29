using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Make_You_Pro
{
	public static class Cycles
	{
		public static int MathematicalAnalysis(int n)
		{
            for (int i = n; i <= 1000; i += n)
			{
				Console.WriteLine(i);
				return i;

			}
		}

		public static int BankDiposit(int m, int y, int p)
		{
			for (int i = 1; i <= y; i++)
			{
				m += m * p / 100;
			}
			Console.WriteLine(m);
			return m;

		}













	}
}
