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
            //constant declaration
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            //variable declaration
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            Console.Write("Employee Type: ");


            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
                Console.WriteLine("Part Time");
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Full Time");

            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Abscent");

            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            //formula for understanding
            Console.WriteLine("Emp Wage: " + empWage);
            Console.WriteLine("empHour: [{1}] X empRatePerHour [{2}] = empWage: [{0}]", empWage, empHrs, EMP_RATE_PER_HOUR);

            Console.ReadLine();
        }
    }
}
