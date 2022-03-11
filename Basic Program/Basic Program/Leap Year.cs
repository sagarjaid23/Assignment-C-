﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Leap_Year
    {
        public Leap_Year()
        {
            IsLeapYear();
        }
        static void IsLeapYear()
        {
            Utility u = new Utility();
            Console.Write("Enter thee year: ");
            int year = u.ReadInt();
            if (year > 999 && year < 10000)
            {
                if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                {
                    Console.WriteLine(year + " is a Leap Year....");
                }
                else
                {
                    Console.WriteLine(year + " is not a Leap Year....");
                }
            }
            else
            {
                Console.WriteLine("Not valid Year............");
            }
        }
    }
}
