using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Make_You_Pro
{
	public static class Arrays
	{
		public static int BestEmployee(int[] ratings)
		{ 
            int max = ratings[0];

			for (int i = 0; i < ratings.Length; i++)
			{
				if (ratings[i] > max)
				{
					max = ratings[i];
				}
			}

             return max;
		}

	}
}
	

