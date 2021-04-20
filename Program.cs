using System;
using System.Collections.Generic;


namespace csharp_errors
{
  class Program
  {
    static void Main(string[] args)
    {
      // try
      // {
      //   Calculator calculator = new Calculator();
      //   int answer = calculator.Divide(42, 0);
      //   Console.WriteLine($"The answer is {answer}");
      // }
      // catch (DivideByZeroException ex)
      // {
      //   Console.WriteLine("Something went wrong!");
      // }


      Company chickenShack = new Company() { Name = "Greasy Pete's Chicken Shack" };
      chickenShack.AddEmployee(new Employee() { FirstName = "Pete", LastName = "Shackleton" });
      chickenShack.AddEmployee(new Employee() { FirstName = "Molly", LastName = "Frycook" });
      chickenShack.AddEmployee(new Employee() { FirstName = "Pat", LastName = "Buttersmith" });

      List<int> employeeIds = new List<int>() { 0, 11, 2 };
      foreach (int id in employeeIds)
      {
        Employee employee = chickenShack.GetEmployeeById(id);
        Console.WriteLine($"Employee #{id} is {employee.FirstName} {employee.LastName}.");
      }
    }
  }

  public class Company
  {
    private List<Employee> _employees = new List<Employee>();
    public string Name { get; set; }

    public void AddEmployee(Employee employee)
    {
      _employees.Add(employee);
    }

    public Employee GetEmployeeById(int id)
    {
      return _employees[id];
    }
  }

  public class Employee
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
  }
}

