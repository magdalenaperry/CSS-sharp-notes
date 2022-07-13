using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Util
  {
    // method declared as static means that it belongs to to the class itself
    public static void PrintEmployees(List<Employee> employees)
    {
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
  }
}