using System;
using System.Collections.Generic;
using System.Text;

namespace JUnitTesting_Programs
{
    class Gregorian_calendar
    {
        public void FindDayOfWeek()
        {
            int day, month, year;
            Console.Write("Enter Day:");
             day = Convert.ToInt32(Console.ReadLine());
             Console.Write("\nEnter Month: ");
             month = Convert.ToInt32(Console.ReadLine());
             Console.Write("\nEnter year: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Day: " + day + "Month:" + month + "year:" + year);
            Utility.CalculateCalendar(day,month,year);
        }
    }
}
