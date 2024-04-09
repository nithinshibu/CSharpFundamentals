using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.C__Fundamentals.OOPS
{
	public class Employees
	{
		//instance fields
		private int _empID;
		private string _empName;

		private double _salary;

		private double _tax;

        public Employees()
        {
			this._salary = 1000;
        }

		//write only property

		public double Tax
		{
			set
			{
				if(value >=0 && value <= 100)
				{
					_tax = value;
				}
			}
		}

        //readonly property

        public double Salary
		{
			get { return _salary; }
		}
		

		//instance property
		public int EmpID
		{
			set { _empID = value; }
			get { return _empID; }
		}

		public string EmpName
		{
			set { _empName = value; }
			get { return _empName; }
		}
		//public static string CompanyName
		//{
		//	set { _companyName = value; }
		//	get { return _companyName; }
		//}
		private static string _companyName;
		public static string CompanyName
		{
			set
			{
				if (value.Length <= 20)
				{
					_companyName = value;
				}
			}
			get { return _companyName; }
		}

	}


}
