using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_Inheritance
{
    [TestClass]
    public class InheritanceTests
    {
        [TestMethod]
        public void PersonExamples()
        {
            //var person = new Person();
            //person.FirstName = "Jordan";
            //person.ToString();

            var customer = new Customer(true, "Jordan", "Read", "4632099770", "jread6477@gmail.com");
            customer.PhoneNumber = "";
            customer.FirstName = "Lawrence";
            customer.IsPremium = true;

            var employee = new Employee();
            employee.FirstName = "Luke";
            employee.HireDate = DateTime.Today;

            var hourlyEmployee = new HourlyEmployee();


            List<Person> people = new List<Person>();
            people.Add(customer);
            people.Add(employee);
            people.Add(hourlyEmployee);
        }
    }
}
