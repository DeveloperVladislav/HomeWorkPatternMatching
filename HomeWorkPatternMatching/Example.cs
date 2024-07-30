using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPatternMatching
{
	public class Example
	{
		//Паттерн типов
		public void Display(object obj)
		{
			switch (obj)
			{
				case int i:
					Console.WriteLine($"Int: {i}");
					break;
				case string s:
					Console.WriteLine($"String: {s}");
					break;
				default:
					Console.WriteLine("Unknown type");
					break;
			}
		}
	}
}
