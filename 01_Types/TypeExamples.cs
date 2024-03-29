﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()    //Class and Method use Pascal cased
        {
            //-- Whole Numbers
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumber = 16;   //Int16
            Int16 anotherSmallNumber = 16;
            int wholeNumber = 32;          //Int32
            long largeWholeNumber = 64;    //Int64

            //--Decimals
            float floatExample = 1.2345678f;
            double doubleExample = 1.2347909d;
            decimal decimalExample = 1.70000m;

            //--Character
            char letter = 'j';

            //--Operators
            int numOne = 17;        //variables us Camel Case
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo;   //Modulous
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");

        }

        [TestMethod]
        public void ReferenceTypes()
        {
            //-- Strings
            string stringExample = "This is a string.";
            string name = "Joshua";

            string declared;
            declared = "Now it's initialized";

            //--Formatting strings
            string concatenate = stringExample + " " + name;                        //This is a string. Joshua                          //concatenation slams two or more strings together.
            string interpolate = $"{name}. Here is the string: {stringExample}";    //Joshua. Here is the string: This is a string.     //interpolation 
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            //--Other Object Examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2019, 6, 29);

            TimeSpan waitTime = randomDate - now;
            Console.WriteLine(waitTime.TotalSeconds);

            //--Collections
            //--Arrays
            string anotherExampleString = "Hello World";
            string[] stringArray = { anotherExampleString, "Hello", "World", "!" };
            string[] students = new string[15];

            Console.WriteLine(stringArray);

            //--Lists
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence");
            //--Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Luke");

            //--Dictionaries
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Josh");

            //--Other Collections
            SortedList<int, string> keyValuePairs = new SortedList<int, string>();
            Stack<string> fristInLastOut = new Stack<string>();
            

        }

        [TestMethod]
      
        
    }
}
