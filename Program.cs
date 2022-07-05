using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static List<string> GetEmployees(){
      //return list of employees
      List<string> employees = new List<string>();
      while(true){
        Console.WriteLine("Please enter employee name: (leave empty to exit). ");
        string input = Console.ReadLine();
        if(input == ""){
          break;
        }
        // create employee instance in employee.cs file
        Employee currentEmployee = new Employee();
        employees.Add(input);
      }
      return employees;
    }

    // Any method that does not return a value must be defined to return void.
    static void PrintEmployees(List<string> employees){
      for (int i = 0; i < employees.Count; i++){
        Console.WriteLine(employees[i]);
      }
    }

    static void Main(string[] args){
      // employee gets
      List<string> employees = GetEmployees();
      PrintEmployees(employees);
    }

  }


}

// [access_modifier] ["static"] return_type name([parameters])
