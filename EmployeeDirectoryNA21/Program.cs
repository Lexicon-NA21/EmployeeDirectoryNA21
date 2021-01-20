using System;

namespace EmployeeDirectoryNA21
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine();
            int x = 5;
            Robot robot0 = new Robot("Kalle");
            Robot robot1 = new Robot("Anna");
            //Robot robot2 = new Robot();
            //Robot robot3 = new Robot();

            robot0.Length = 5;
            int length = robot0.Length;

            string robotName = robot0.Name;

            robot0.Name = "Kalle";
            robot0.Walk(10);

           // robot0.age = 5;

        }
    }
}
