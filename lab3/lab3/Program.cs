using System;
namespace lab3
{
	class Program
	{
		static void Main(string[] args)
		{
			char znak;
			Console.WriteLine("Введите знак для реализации операции:");
			Console.WriteLine("(*)");
			znak = Convert.ToChar(Console.ReadLine());
			switch (znak)
			{

				case '*':
					total = a * b;
					Console.WriteLine("Результат:" + total);
					break;


			}

		}

	}
}

