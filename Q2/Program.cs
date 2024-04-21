using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2.	Create a C# console application. Consider a scenario where you are designing a system to manage employee information. Design a class named "Employee" with the following properties and methods.

a)	Create an instance of the "Employee" class, representing an employee with an ID of 101, full name "John Doe," and a salary of 50000.
b)	Access and display the employee ID using the read-only property.
c)	Update the full name of the employee using the read-write property.
d)	Attempt to modify the salary directly from external code (outside the class). Observe and comment on the result
*/

namespace Q2
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Employee employee = new Employee(101, "John Doe", 50000.00);

            Console.WriteLine("Employee Information ");
            employee.DisplayEmployeeInfo();

            Console.WriteLine($"Employee ID {employee.EmployeedID}");

            employee.FullName = "Jane Smith";
            Console.WriteLine($"Updated Full Name {employee.FullName}");

            employee.Salary = 55000;
            Console.WriteLine($"Updated salary  {employee.salary}");

            Console.ReadLine();
        }
    }
}

internal class Employee
{
    public int employeeID;
    public string fullName;
    public double salary;

    public Employee(int employeeID, string FullName, double salary)
    {
        this.employeeID = employeeID;
        this.fullName = FullName;
        this.salary = salary;
    }
    public int EmployeedID => employeeID;

    public string FullName
    {
        get => FullName;
        set => FullName = value;

    }
    public double Salary
    {
        get => salary;
        set => salary = value;
    }

    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Employee ID {employeeID}");
        Console.WriteLine($"Full Name {employeeID}");
        Console.WriteLine($"Salary {employeeID}");
    }
}
