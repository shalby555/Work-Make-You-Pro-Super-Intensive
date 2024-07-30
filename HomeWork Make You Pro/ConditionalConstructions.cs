using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Make_You_Pro
{
	public static class ConditionalConstructions
	{
		public static int EmployeeBonus(int a, int b)
		{
			int result = 0;
			if (a < b)
			{
				 result = a * 5 / 100;
			}
			else if (a >= b)
			{
				 result = (a * 10 / 100);
            }
			return result;
		}

		public static bool IsDiscountCard (int a, int b,int c)
		{
		   return a >= 60 || b >= 4 && c >= 5000;
		}
	}
}
