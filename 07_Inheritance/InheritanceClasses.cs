using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritance
{
    abstract class Person                       //abstract turns person into a concept.  now you cannot just add a person you must add customers or employees that can use the properties of person. 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, string phoneNumber, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

    }

    class Customer : Person
    {
        public bool IsPremium { get; set; }

        public Customer() { }
        public Customer(bool isPremium, string firstName, string lastName, string phoneNumber, string email)
            : base(firstName, lastName, phoneNumber, email)      //calling on base constructor from Person
        {
            IsPremium = isPremium;
        }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public DateTime HireDate { get; set; }
    }

    class HourlyEmployee : Employee
    {
        public decimal HourlyWage { get; set; }
        public double Hours { get; set; }
    }

    class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
    }
}
