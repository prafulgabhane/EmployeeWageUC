// UC- 8 Compute Employee Wage for Multiple Company in Procedural Way Using Class Methods

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Claims; 
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageUC
{
    internal class Program
    {
        //constant declaration
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
      
        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //variable declaration
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day " + totalWorkingDays + " Emp Hours: " + empHrs);
            }

            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total: Employee Wage for company :" + company + "is " + totalEmpWage);
            Console.ReadLine();
            return totalEmpWage;

        }
        //Main Method
        static void Main(string[] args)
        {
            computeEmpWage("DMart",20,2,10);
            computeEmpWage("Reliance", 10, 4, 10);
        }
    }
}
