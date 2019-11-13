using System;
using System.Collections.Generic;
using System.Text;

namespace JUnitTesting_Programs
{
    class TemperatureConversion
    {
        public void FindTemperature()
        {
            Utility u = new Utility();
            Console.Write("Enter Temperaure In Celcius:");
            double CelTemp = Convert.ToDouble(Console.ReadLine());
            Utility.ConvertCelToFarehnite(CelTemp);
           
            Console.Write("\n\nEnter Temperaure In Farehnite:");
            double farehnitetemp = Convert.ToDouble(Console.ReadLine());
            Utility.ConvertFarehniteToCel(farehnitetemp);
           

        }
    }
}
