using System;
namespace Menu
{
	class Program
	{
		static void Main(string[] args)
		{
			double total;
			char znak;
			Console.WriteLine("Введите знак для реализации операции:");
			Console.WriteLine("(+)");
			znak = Convert.ToChar(Console.ReadLine());
			switch (znak)
			{

				case '+':
					total = a + b;
					Console.WriteLine("Результат:" + total);
					break;


			}

		}

	}
}
