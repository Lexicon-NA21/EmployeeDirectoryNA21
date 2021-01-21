using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDirectoryNA21
{
    public static class Util
    {
        public static string AskForString(string prompt)
        {
            bool success = false;
            string answer;

            do
            {
                Console.WriteLine(prompt);
                answer = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(answer))
                {
                    Console.WriteLine("You must enter something");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }
    }
}
