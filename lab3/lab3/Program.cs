using System;
namespace lab3
{
	class Program
	{
		static void Main(string[] args)
		{
			double a;
			double b;
			double total;
			Console.WriteLine("Введите А: ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите B: ");
			b = Convert.ToDouble(Console.ReadLine());
			char znak;
			Console.WriteLine("Введите знак для реализации операции:");
			Console.WriteLine("(+)");
			Console.WriteLine("(-)");
			Console.WriteLine("(*)");
			Console.WriteLine("(/)");
			znak = Convert.ToChar(Console.ReadLine());
			switch (znak)
			{ }
		}
	}
}
