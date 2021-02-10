using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDirectoryNA21
{
    public class ConsoleUI : IUI
    {
        //Metoder
        public string GetInput()
        {
            return Console.ReadLine();
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        public void Print(Employee employee)
        {
            Console.WriteLine(employee);
        }
    }
}
