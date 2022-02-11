using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]  //shortcut testm 'tab' 'tab'
        public void CookieTests()
        {
         //call class, reference type
            Cookie cookie = new Cookie();  //new object called cookie  //'new up' and object =creating an object, or an instance of the class
            cookie.Name = "snickerdoodle"; 
            cookie.HasNuts = false;

            Cookie anotherCookie = new Cookie();  
            anotherCookie.Name = "Something else";
            anotherCookie.GramsOfFlour = 10;

            Cookie snickerdoodle = new Cookie("Snickerdoodle", false, 11.5);    //setting properties in the parameters using Constructor 
            Cookie newCookie = new Cookie("Peanut Butter", true, 150);          //this allows us to call on Constructors to create objects without retyping multiple lines of code for each instance
        }

        [TestMethod]  //shortcut testm 'tab 'tab'
        public void VehicleTests()
        {
            Vehicle car = new Vehicle();  //new up  
            car.TypeOfVehicle = VehicleType.Car;  //.car is coming from VehicleType
            //car object, TypeOfVehicle property, that is of type VehicleType, and we are assigning it a value of that VehicleType enum .car
            
            //Object Initialization Syntax//
            Vehicle newCar = new Vehicle                //use {} instead of ()            
            {                                           //creating new object using {}  allows us to initialize new object without using overloaded constructors
                TypeOfVehicle = VehicleType.Car,        //Need an empty constructor to use, in this case 'Vehicle' is the constructor
                Make = "Honda",                         //list of properties separated by ',' same as within ()
                Model = "Civic"
            }; //semi-colon important at end of 'object initialization syntax'
        }
    }
}
