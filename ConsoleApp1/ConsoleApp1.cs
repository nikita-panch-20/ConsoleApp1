using System;
namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int a, b, c;
            Console.WriteLine("Enter the First Number: ");
			a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
			b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number: ");
			c = Convert.ToInt32(Console.ReadLine());
			int res = Largest(a,b,c);
		}
		static int Largest(int a, int b, int c) 
		{
			int result = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
		}
	}

}