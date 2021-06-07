using System;

namespace ConsoleApp15
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<string> list = new MyList<string>();
			list.Add("z");
			list.Add("x");
			list.Add("Тычка");
			list.Add("Пауза");
			list.Add("?????");
			list.Add("анпауз");
			list.Add("c");
			list.Print();
		}
	}
}

