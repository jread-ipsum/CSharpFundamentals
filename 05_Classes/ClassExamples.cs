using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    //declare "class", then give "Name" ie: class Cookie
    public class Cookie
    {
                   //Properties =variables for whole class   must define type and give name
        public string Name { get; set; }            //getters and setters.  basically methods. 
        public bool HasNuts { get; set; }           //get's value of HasNuts  //set's value of HasNuts
        public double GramsOfFlour { get; set; }


        public Cookie()   //empty constructor   //'Overloading' means we have more than one version of a 'method' in this case a 'constructor'
        {

        }

                        //pass in   //define parameters
        public Cookie(string name, bool hasNuts, double gramsOfFlour)    //constructor //when 'new up' a Cookie with these parameters set, this code fires off 
        {
          
            Name = name;                    //'Name' property from above = 'name' in parameter 
            HasNuts = hasNuts;              //HasNuts property =  'hasNuts' in parameter
            GramsOfFlour = gramsOfFlour;    //GramsOfFlour property = 'gramsOfFlour' parameter
        }
    }

    //enum      //name    //creating new type and type needs defined values {}    //enum is short for enumeration //enum is "defining a customized type"
    public enum VehicleType { Car, Truck, Van, Motorcycle, Spcaeship, Plane, Boat }
    public class Vehicle   //new class
    {
        public string Make { get; set; }  //new property    //shortcut= prop tab tab.  defaults to int but can change to any type.
        public string Model { get; set; }  //new property
        public double Mileage { get; set; }
        public string Engine { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public Vehicle() //constructor
        {

        }
    }


    //Example using class object as a property type
    public class Order   //new class
    {
        public string CustomerName { get; set; }  //propety  //shortcut prop 'tab' 'tab'
        public Cookie OrderedProduct { get; set; } //a class can be used as a type
        public decimal TotalCost { get; set; }
    }
}
