using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        //Get , ser (set نعطيه بس ما يرجع شي ) Get (يرجع الي عطيته ).
        public void SetfirstName(string firstName)
        {

            this.firstName = firstName;


        }
        public string GetfirstName()
        {

            return firstName;


        }
        public void SetlastName(string lastName)
        {

            this.lastName = lastName ;


        }
        public string GetlastName()
        {

            return lastName;


        }
        public void Setage(int age)
        {
            //Give him the year -age الثابت
            this.age = 2023-age;


        }
        public int Getage()
        {

            return age;


        }
        public void Setsalary(decimal salary)
        {

            this.salary = salary;


        }
        public decimal Getsalary()
        {

            return salary;


        }

        public string printInfo()
        {
            return $"your name is {firstName} {lastName} and your age: {age} and your salary: {salary}";




        }


    }
}
