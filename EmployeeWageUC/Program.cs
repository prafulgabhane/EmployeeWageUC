using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageUC
{
    internal class Program
    {
        //constant declaration
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        static void Main(string[] args)
        {
            //variable declaration
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            Console.Write("Employee Type: ");

            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    Console.WriteLine("Part Time");
                    break;

                case IS_FULL_TIME:
                    empHrs = 8;
                    Console.WriteLine("Full Time");
                    break;

                default:
                    empHrs = 0;
                    break;

            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage: " + empWage);
            //formula for understanding
            Console.WriteLine("empHour: [{1}] X empRatePerHour [{2}] = empWage: [{0}]", empWage, empHrs, EMP_RATE_PER_HOUR);
            Console.ReadLine();
        }
    }
}
