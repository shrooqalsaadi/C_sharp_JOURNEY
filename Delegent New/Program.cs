namespace Delegent_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[]
           {
                new Employee { Age = 25, Name = "shrooq", salary  = 500m, TotalSale = 45000m },
                new Employee { Age =30, Name = "Joy", salary  = 2300m, TotalSale = 22000m },
                new Employee { Age = 29, Name = "Tetoo", salary  = 7800m, TotalSale = 900000m },
           };

            Report report = new Report();
            report.ProcessEmployee(employee, " salary more than 70000 :", (employee1) => employee1.salary >= 70000);
            report.ProcessEmployee(employee, " salary more than 5000 :", (employee1) => employee1.salary >= 5000);
            report.ProcessEmployee(employee, " salary more than 3200 :", (employee1) => employee1.salary >= 3200);
            report.ProcessEmployee(employee, "Age more than 24 :", (employee1) => employee1.Age >= 24);
            report.ProcessEmployee(employee, "Age more than 28 :", (employee1) => employee1.Age >= 28);
            report.ProcessEmployee(employee, "Age more than 22 :", (employee1) => employee1.Age >= 22);
            report.ProcessEmployee(employee, "Total Sale more than 70000", (employee1) => employee1.TotalSale >= 70000);
            report.ProcessEmployee(employee, "Total Sale more than 23000", (employee1) => employee1.TotalSale >= 23000);
            report.ProcessEmployee(employee, "Total Sale more than 80000", (employee1) => employee1.TotalSale >= 800);
        }
    }
    }
