using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace Encapsulation
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        public Person(string firstName, string lastName, int age,decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get => firstName;
            
                
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("less than 3 simbols");
                }
                firstName = value;
            }
           
        }
        public string LastName
        {
            get => lastName;

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("less than 3 simbols");
                }
                lastName = value;
            }
            
        }
        public int Age
        {
            get => age;
            
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Negative age or coca cola zero!");
                }
                age = value;    
            }
        }
        public decimal Salary
        {
            get => salary;
            
           
            private set
            {
                if (value < 650)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
                salary = value;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old and have {this.Salary:f2} ";
        }
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age>30)
            {
                this.Salary += this.Salary * percentage / 100;
            }
            else
            {
                this.Salary += this.Salary * percentage / 200;
            }
        }
    }
}