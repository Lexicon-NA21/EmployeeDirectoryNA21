using System;

namespace EmployeeDirectoryNA21
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            robot.Length = 5;
            int length = robot.Length;

            robot.Name = "Kalle";
        }
    }
}
