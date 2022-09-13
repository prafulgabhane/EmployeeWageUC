using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageUC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empPresent = 1;

            // generating random value

            Random random = new Random();
            int empCheck = random.Next(0, 2);
            Console.WriteLine("Random Value:" + empCheck);

            // condition check if else

            if (empPresent == empCheck)
                Console.WriteLine("Employee is Present");

            else
                Console.WriteLine("Employee is Absent");
            Console.ReadLine();
        }
    }
}
