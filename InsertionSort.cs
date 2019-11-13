using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class InsertionSort
    {
        public void StringSort()
        {
            Console.Write("\nEnter size Of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] stringarray = new string[size];
            Console.Write("\nEnter Strings In Array:");
            Utility.ReadStringArray(stringarray);
            Console.Write("\nString Array Before Sort:");
            Utility.PrintStringArray(stringarray);
            Utility.InsertionSort(stringarray);
            Console.Write("\nString Array After Sort:");
            Utility.PrintStringArray(stringarray);
        }

    }
}
