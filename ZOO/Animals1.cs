using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
	public  class Animals1
	{
		public string Name { get; set; }
		private int Age
		{
			get
			{
				return _age;
			}
			set
			{
				_age = value;
			}
		}
		private int _age;
		public string KindOfAnimal { get; set; }
		public int AreaPerIndividual { get; set; }
		public string Feeds { get; set; }
		public string SoundAnAnimal { get; set; }









	}
}
