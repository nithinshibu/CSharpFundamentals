using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.C__Fundamentals.IntroductionToC_
{
	public class ConsoleClass
	{
		public void ConsoleDemo()
		{
			//Print the messages side by side
			Console.Write("Hello");
			Console.Write("World");

			//Print the message line by line			
			Console.WriteLine("Welcome to");
			Console.WriteLine("Programming");

			//Wait for pressing some key on the keyboard
			Console.ReadKey();

			//Clear the screen
			Console.Clear();

			Console.WriteLine("Thank you");
			Console.ReadKey();
		}
	}
}
