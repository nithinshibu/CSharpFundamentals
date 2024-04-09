namespace CSharpFundamentals.C__Fundamentals.IntroductionToC_
{
	//default access modifier is :- internal
	internal class ClassAndObjects
    {
       public void MethodExample()
        {
            Car newCar = new Car();
            newCar.CarModel = "Toyota";
        }
       
    }

    public class Car
    {
        public string CarModel { get; set; } = "";
       
    }
}
