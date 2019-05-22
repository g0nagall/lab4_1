using System;
using System.IO;
using System.Linq;

namespace lab4_1
{
	class Program
	{
		static void Main(string[] args)
		{
			string line;
			char[] symbol = { ' ', ',', '.', '!', '?', ':', ';', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
			using (StreamReader MyFile = new StreamReader("input.txt"))
			{
				while ((line = MyFile.ReadLine()) != null)
				{
					Console.WriteLine("Symbols in file: ");
					Console.WriteLine(line); 
					string result = string.Concat(line.Split(symbol, StringSplitOptions.RemoveEmptyEntries).Select(word => word.Last()));
					Console.WriteLine("wanted line: ");
					Console.WriteLine(result);
				}
			}
			Console.ReadLine();

		}
	}
}