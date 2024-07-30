using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPatternMatching
{
	public class Person
	{
		public string? Name { get; set; }
		public int Age { get; set; }

		//Паттерн свойств
		public void Display(Person person)
		{
			switch (person)
			{
				case Person { Age: > 18 } p:
					Console.WriteLine($"{p.Name} is an adult");
					break;
				case Person { Age: <= 18 } p:
					Console.WriteLine($"{p.Name} is a minor");
					break;
			}
		}
	}
}
