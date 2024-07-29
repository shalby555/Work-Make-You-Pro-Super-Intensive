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
		public static EmployeeBonus(int a, int b)
		{
			if (a < b)
			{
				int result = a * 5 / 100;
			}
			else if (a >= b)
			{
				int result = (a * 10 / 100);
            }
			return result;
		}
	}
}
