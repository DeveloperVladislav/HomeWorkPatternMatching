namespace HomeWorkPatternMatching
{
	public class Program
	{

		//Паттерны кортежей
		public void Display((int, string) tuple)
		{
			switch (tuple)
			{
				case (int age, string name) when age > 18:
					Console.WriteLine($"{name} is an adult");
					break;
				case (int age, string name):
					Console.WriteLine($"{name} is a minor");
					break;
			}
		}


		//Реляционный и логический паттерны
		public void Display(int number)
		{
			switch (number)
			{
				case > 0 and < 10:
					Console.WriteLine("Number is between 1 and 9");
					break;
				case > 10 and < 20:
					Console.WriteLine("Number is between 11 and 19");
					break;
				default:
					Console.WriteLine("Number is out of range");
					break;
			}
		}

		//Паттерны списков
		public void Display(List<int> numbers)
		{
			switch (numbers)
			{
				case List<int> { Count: 0 }:
					Console.WriteLine("Empty list");
					break;
				case List<int> { Count: > 0 } n:
					Console.WriteLine($"List with {n.Count} items");
					break;
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			//Паттерны типов
			Console.WriteLine("-------------------Паттерны типов");
			Example example = new Example();

			example.Display(10);
			example.Display("Hello");
			example.Display(new object());


			//Паттерны свойств
			Console.WriteLine("-------------------Паттерны свойств");
			Person person1 = new Person { Name = "John", Age = 25 };
			Person person2 = new Person { Name = "Alice", Age = 15 };

			Person person = new Person();
			person.Display(person1);
			person.Display(person2);


			//Паттерны кортежей
			Console.WriteLine("-------------------Паттерны кортежей");
			Program program = new Program();

			(int, string) human1 = (25, "John");
			program.Display(human1);

			(int, string) human2 = (15, "Alice");
			program.Display(human2);


			//Позиционный паттерн
			Console.WriteLine("-------------------Позиционный паттерн");
			Point origin = new Point(0, 0);
			Point point1 = new Point(5, 10);

			Point point = new Point();
			point.Display(origin);
			point.Display(point1); 


			//Реляционный и логический паттерны
			Console.WriteLine("-------------------Реляционный и логический паттерны");

			program.Display(5);   
			program.Display(15); 
			program.Display(25);


			//Паттерны списков
			Console.WriteLine("-------------------Паттерны списков");
			List<int> emptyList = new List<int>();
			program.Display(emptyList);

			List<int> numbers = new List<int>() { 1, 2, 3, 4 };
			program.Display(numbers);
		}
	}

}
