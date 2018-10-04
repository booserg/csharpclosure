using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Action> actions = new List<Action>();
			for (int i = 0; i < 10; i++)
				actions.Add(() => Console.WriteLine(i));

			foreach (var act in actions)
				act();
		}
	}
}
