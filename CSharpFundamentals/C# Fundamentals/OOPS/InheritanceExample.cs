namespace CSharpFundamentals.C__Fundamentals.OOPS
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeLocation { get; set; }

    }

    public class Manager : Employee
    {
        public string Department { get; set; }

        //field
        //private string _departmentName;

        //property 
        //public string DepartmentName { set { _departmentName = value; } get { return _departmentName; } }


        public long GetTotalSalesOfTheYear()
        {
            return 10000;
        }

    }

    public class SalesMan
    {
        public string Region {  get; set; }

        public long GetSalesOfTheCurrentMonth()
        {
            return 1000;
        }
    }
}
