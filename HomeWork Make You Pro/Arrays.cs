using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Make_You_Pro
{
	public static class Arrays
	{
		public static int BestEmployee(int a, int b, int c, int f)

		{
			int[] ratings = new int[] { a, b, c, f };

			int max = ratings[0];

			for (int i = 0; i < ratings.Length; i++)
			{
				if (ratings[i] > max)
				{
					max = ratings[i];
				}
			}
			Console.WriteLine(max);

			return max;
		}

	}
}
	

