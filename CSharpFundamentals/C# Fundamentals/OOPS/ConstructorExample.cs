using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.C__Fundamentals.OOPS
{
	public class EmployeeUsers
	{
		//instance fields
		public int empID;
		public string empName;
		public string job;

		//static field

		public static string companyName;

		//instance constructor
		public EmployeeUsers(int empID, string empName, string job)
		{
			this.empID = empID;
			this.empName = empName;
			this.job = job;
		}

		//static constructor

		static EmployeeUsers()
		{
			companyName = "Test Company";
		}
	}
}
