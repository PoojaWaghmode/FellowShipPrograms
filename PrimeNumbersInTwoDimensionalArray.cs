
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    using System;
    class PrimeNumbersInTwoDimensionalArray
    {
        

        public void InsertPrimeNumbersInTwoDimensionalArray()
        {
            int[,] TwoDimensionalArray = new int[10, 100];
            int[] primenumbers = Utility.PrimeNumbers();
            int[] range = { 0, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };
            for(int i=0;i<10;i++)
            {
                for(int j=0;j<100;j++)
                {
                    if(range[i]<=primenumbers[j]&&primenumbers[j]<=range[i+1])
                    {
                        TwoDimensionalArray[i, j] = primenumbers[j];
                        Console.Write(TwoDimensionalArray[i, j] + "   ");

                    }
                }
                Console.WriteLine();
            }
        }

    }

}