using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.C__Fundamentals.OOPS
{
	public class Products
	{
		//fields

		public int productID;
		public string productName;
		public double cost;
		public double tax;
		public int quantityInStock;
		public static int TotalNoOfProducts;
		public const string CategoryName = "Electronics";
		public readonly string dateOfPurchase;

        public Products()
        {
            dateOfPurchase = DateTime.Now.ToShortDateString();
        }

		//Set method for productID

		public void SetProductID(int value)
		{
			productID = value;
		}

		//Get method for productID

		public int GetProductID()
		{
			return productID;
		}

		public static void SetTotalNoOfProducts(int total)
		{
			TotalNoOfProducts= total;
		}
		
		public static int  GetTotalNoOfProducts()
		{
			return TotalNoOfProducts;
		}

		public void CalculateTax(in double percentage)
		{			
			tax = 5000 * percentage/100;
		}
		

	}

	public class DefaultValuesExample
	{
		public static void DisplayMessage(string message="Hello World")
		{
			Console.WriteLine(message);
		}
	}

	public class NamedParamterExample
	{
		public string ExampleMethod(string value,string data)
		{
			return value + data;
		}
	}

	public class ThisExample
	{
		public string sampleField;

        public ThisExample(string sampleField)
        {
			this.sampleField = sampleField;
        }
		

	}


	public class Student
	{

		public void DisplaySubjects(params string[] subjects)
		{
			foreach(string sub in subjects)
			{
				Console.WriteLine(sub);
			}
		}


		public int grade = 2;

		public void PrintGrade()
		{
            Console.WriteLine("Grade "+ grade);
        }

		public ref int DoWork()
		{			
			return ref grade;
		}
	}

	
	
}
