using System;

namespace EmployeeDirectoryNA21
{
    class Program
    {
        static Payroll payroll = new Payroll();

        static void Main(string[] args)
        {
            SeedData();

            do
            {
                ShowMainMeny();

                switch (Console.ReadLine())
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        PrintEmployee();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

            } while (true);
        }

        private static void AddEmployee()
        {
            Console.WriteLine("Add a new Employee");
            string name = Util.AskForString("Name: ");
        
            int salary = int.Parse(Util.AskForString("Salary: "));

            payroll.AddEmplyee(name, salary);
        }

        private static void ShowMainMeny()
        {
            Console.WriteLine("1. add employee");
            Console.WriteLine("2. print employees");
            Console.WriteLine("3. Quit");
        }

        private static void PrintEmployee()
        {
            Employee[] employees = payroll.GetEmployees();

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
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
