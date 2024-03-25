using System.Security.Cryptography.X509Certificates;

namespace CSharpFundamentals.C__Fundamentals.OOPS;

public class Product
{
    //fields
    public int productID;
    public string productName;
    public double cost;
    public int quantity;

    public void Method()
    {  
        string message = displayMessage();

		BankAccount account = new BankAccount("sampleConnectionString");
        var cs = account.connectionString;
	}

    static string displayMessage()
    {
        
        return "Hello World";
    }
}

public class BankAccount
{ 
    public readonly string connectionString;

    public BankAccount()
    {
        
	}

    public BankAccount(string readonlyValue)
    {
		this.connectionString = readonlyValue;
	}
}

public class ConstantClass
{
	public const double pie = 3.1415926535897931;
}