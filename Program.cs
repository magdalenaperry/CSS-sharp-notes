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
    static void PrintEmployees(List<Employee> employees){
      
      for (int i = 0; i < employees.Count; i++)
      {
        // template formating {0, 1, 2}
        // {0, -10} = left aligned and padded to 10 characters
        // \t = tab
        // {1, -20} = left aligned and padded to 20 characters
        // {2} = no formatting

        string template = "{0,-10}\t{1,-20}\t{2}";
        Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
      }
    }

    static void Main(string[] args){
      // employee gets
      List<Employee> employees = GetEmployees();
      PrintEmployees(employees);
    }

  }

}