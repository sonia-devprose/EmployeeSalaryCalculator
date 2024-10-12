// See https://aka.ms/new-console-template for more information

using System;

namespace EmployeeSalaryCalculator

{

    class Program

    {
        static void Main(string[] args)
        {


            // short data type used for employee ID	
            short employee_id = 1234;
            Console.WriteLine("The employee ID is: " + employee_id);

            // int data type used for hours worked per week
            int hours_worked_week = 40;
            Console.WriteLine("Hours worked per week: " + hours_worked_week);

            // float data type used for hourly wages in decimal
            float wage_hour = 500.56f;
            Console.WriteLine("Wages per hour: $" + wage_hour);

            // float data type used for monthly bonus in decimal
            float monthly_bonus = 1234.56f;
            Console.WriteLine("Monthly bonus: $" + monthly_bonus);

            // double used for high-precision financial calculations

            double annual_salary = (hours_worked_week * wage_hour * 52) + (12 * monthly_bonus);
            Console.WriteLine("Annual salary: $" + annual_salary);








        }



    }


}





