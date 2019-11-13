using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    public class Utility
    {
       
        public static int[] PrimeNumbers()
        {
            int i = 0, num = 0, primecounter = 0,size=0;
            string primenumber = "";
            int[] TwoDimensionalArray = new int[1000];

            // for loop for getting numbers from 2 to last number 

            for (i = 0; i < 1000; i++)
            {
                int counter = 0;
                for(num=i;num>=1;num--)
                {
                    if(i%num==0)
                    {
                        counter = counter+1;
                    }
                }
                if(counter==2)
                {
                    TwoDimensionalArray[size] = i;
                    primecounter++;
                    size++;
                }
               
            }
            return TwoDimensionalArray;
        }

    }
}
