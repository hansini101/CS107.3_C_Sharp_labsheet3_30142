using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(101, "John Doe", 50000.00);

            Console.WriteLine("Employee Information ");
            employee.DisplayEmployeeInfo();

        }
    }
}

internal class Employee
{
    public int employeeID;
    public string FullName;
    public double salary;

    public Employee(int employeeID, string FullName, double salary)
    {
        this.employeeID = employeeID;
        this.FullName = FullName;
        this.salary = salary;
    }
}
