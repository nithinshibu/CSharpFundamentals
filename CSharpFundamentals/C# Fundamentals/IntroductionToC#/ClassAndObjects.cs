using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
