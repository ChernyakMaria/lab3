using System;
namespace lab3{
	class Program
	{
		static void Main(string[] args)
		{
			double a;
			Console.WriteLine("Введите A: ");
			a = Convert.ToDouble(Console.ReadLine());
			double b;
			Console.WriteLine("Введите B: ");
			b = Convert.ToDouble(Console.ReadLine());
			double total;
			char znak;
			Console.WriteLine("Введите знак для реализации операции:");
			Console.WriteLine("(+)");
			Console.WriteLine("(-)");
			Console.WriteLine("(*)");
			Console.WriteLine("(/)");
			znak = Convert.ToChar(Console.ReadLine());
			switch (znak)
			{

				case '+':
					total = a + b;
					Console.WriteLine("Результат:" + total);
					break;

				case '-':
					total = a - b;
					Console.WriteLine("Результат:" + total);
					break;

				case '*':
					total = a * b;
					Console.WriteLine("Результат:" + total);
					break;

				case '/':

					total = (float)a / b;
					Console.WriteLine("Результат: " + total);

					if (b == 0)
					{
						Console.WriteLine("На ноль делить нельзя.");
					}
					break;


			}

		}

	}
}

