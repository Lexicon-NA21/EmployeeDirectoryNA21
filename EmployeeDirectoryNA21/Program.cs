using System;

namespace EmployeeDirectoryNA21
{
    class Program
    {
        static Payroll payroll = new Payroll();

        static void Main(string[] args)
        {
            SeedData();

            Employee[] employees = payroll.GetEmployees();

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
            }
        }

        private static void SeedData()
        {
            payroll.AddEmplyee("Kalle", 10000);
            payroll.AddEmplyee("Anna", 20000);
            payroll.AddEmplyee("Lisa", 30000);
        }
    }
}
