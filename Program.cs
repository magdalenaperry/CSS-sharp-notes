using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static List<Employee> GetEmployees(){
      //return list of employees
      List<Employee> employees = new List<Employee>();
      while(true){
        Console.WriteLine("Please enter employee name: (leave empty to exit). ");
        string firstName = Console.ReadLine();
        if(firstName == ""){
          break;
        }

        // add read line for each value needed for employee
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter ID: ");
        int id = Int32.Parse(Console.ReadLine());
        Console.Write("Enter Photo URL: "); 
        string photoUrl = Console.ReadLine(); 
        // create employee instance in employee.cs file
        Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
        employees.Add(currentEmployee);
      }
      return employees;
    }

    // Any method that does not return a value must be defined to return void.
    static void Main(string[] args){
      // employee gets
      List<Employee> employees = GetEmployees();
      Util.PrintEmployees(employees);
    }

  }

}