﻿using System;

namespace EmployeeWagesUC1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Full_Time = 2;
            int Emp_rate = 20;
            int Emp_Hour, Emp_Wages;
            Random r = new Random();
            int check = r.Next(1, 3);
            if (check == Full_Time)
            {
                Console.WriteLine("Employee is present");
            }
            else
               
            Console.WriteLine("Employee Wages is absent");
        }
    }
}
