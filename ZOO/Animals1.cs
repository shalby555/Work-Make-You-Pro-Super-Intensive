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
		public int Age { get; set; }
		public string KindOfAnimal { get; private set; }
		public int AreaPerIndividual { get;private set; }
		public string Feeds { get;private set; }
		public string SoundAnAnimal { get; set; }
        public Animals1()
		{
			Name = Name;
			Age = Age;
			


		}
		public void Sound()
		{
			Console.WriteLine($"{Name} RRRRR");
		}
     }
}
