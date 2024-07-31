namespace ZOO
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Animals1 tigr = new Animals1();
			tigr.Name = "Shirhan";
			tigr.Age = 10;
			tigr.Sound();

			Animals1 tigr1 = new Animals1();
			tigr.Name = "Simba";
			tigr.Sound();
		}
	}
}
