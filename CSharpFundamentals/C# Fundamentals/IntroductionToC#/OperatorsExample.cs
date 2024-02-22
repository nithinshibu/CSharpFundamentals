using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.C__Fundamentals.IntroductionToC_
{
	internal class OperatorsExample
	{
		public static void OperatorsExamples()
		{
			//Arithmetical Operators
			decimal a = 10M;
			decimal b = 3M;
			decimal c = a + b; // output: 13
			decimal f = a / b;// opt: 3.333

			//Assignment Operators
			a += 20M; // 30
			a %= 3M; // 1

			//Increment / Decrement Operators
			a = 10M;
            Console.WriteLine(a++);//Ouput:10,it will return the initial value 10, and then updates the value to 11 in memory)
            Console.WriteLine(++a);//Output:12, the above statement updates the value of a as 11, ++a will increment it and then returns hence 11 + 1 = 12.

            Console.WriteLine(--a);//Output = 12 -1 = 11;
            Console.WriteLine(a--);//Output=11, then updates a=10;
            Console.WriteLine(a);//Output=10


			//Comparison Operators

			bool b1 = a == 10;
            Console.WriteLine(b1); //Output = true

			bool b2 = a != 10;
			Console.WriteLine(b2); //Output = false

			bool b3 = a < 10;
			Console.WriteLine(b3); //Output = false

			bool b4 = a <= 10;
			Console.WriteLine(b4); //Output = true


			//Logical Operators

			bool b7 = a == 10 & b == 10;
            Console.WriteLine(b7);//Output=false

			bool b8 = a == 10 && b == 10;
			Console.WriteLine(b8);//Output=false

			bool b9 = !(a == 10); //Ouput=false

			//In this ^ , only one of the specified condition should be true , it doesn't expect both operands to be true
			bool b10 = a == 10 ^ b == 10;
			Console.WriteLine(b10); //Ouput=true

			//Concatenation operator

			string message = "Hello";
			string message2 = "World";

			string wholeMessage = message+message2;


			//Ternary
			int age = 20;

			string title = (age < 13) ? "Child" : (age >= 13 && age <= 19) ? "Teenager" : "Adult";

			//operator precedence
			double z = 10 + 4 * 30 / 10; // 4*30 =120, 120/10=12, 10+ 12 = 22
			//Output =22

		}
	}
}
