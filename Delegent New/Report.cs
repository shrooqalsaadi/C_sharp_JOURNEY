using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegent_New
{
    internal class Report
    {
        public delegate bool ISValid(Employee employee1);
        public void ProcessEmployee(Employee[] employee1, string Title, ISValid condition )
        {
            Console.WriteLine(Title);
            foreach (Employee emp in employee1)
            {
                if (condition(emp))

                {
                    Console.WriteLine(" Name : || Age: || Total Sale: ||Salary:\n");
                    Console.WriteLine($"{emp.Name} || {emp.Age}     || {emp.TotalSale}       || {emp.salary}\n");

                }

            }
            Console.WriteLine("\n\n");
        }
    }
}
