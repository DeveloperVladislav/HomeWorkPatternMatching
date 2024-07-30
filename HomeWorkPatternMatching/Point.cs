using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPatternMatching
{
	public class Point
	{
		//Позиционный паттерн
		public int X { get; }
		public int Y { get; }

		public Point()
		{

		}

		public Point(int x, int y) => (X, Y) = (x, y);

		public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);


		
		public void Display(Point point)
		{
			switch (point)
			{
				case Point(0, 0):
					Console.WriteLine("Origin");
					break;
				case Point(var x, var y):
					Console.WriteLine($"Point at ({x}, {y})");
					break;
			}
		}
	}
}
