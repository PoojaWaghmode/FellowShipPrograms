using System;
namespace Algorithm_Programs
{
    class Utility
    {
        public static void BubbleSortOfArray(int[] intarray, int size)
        {
            int temp;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (intarray[i] > intarray[j])
                    {
                        temp = intarray[i];
                        intarray[i] = intarray[j];
                        intarray[j] = temp;
                    }
                }
            }

        }
        public static void ReadIntArray(int[] intarray)
        {
            for (int i = 0; i < intarray.Length; i++)
            {
                Console.Write(" {0}:  ", i);
                intarray[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void PrintIntarray(int[] intarray)
        {
            for (int i = 0; i < intarray.Length; i++)
            {
                Console.Write(" {0}:  ", i);

            }
        }
        public static void ReadStringArray(string[] stringarray)
        {
            for (int i = 0; i < stringarray.Length; i++)
            {
                Console.Write(" {0}:  ", i);
                stringarray[i] = Console.ReadLine();
            }
        }
        public static void PrintStringArray(string[] stringarray)
        {
            for (int i = 0; i < stringarray.Length; i++)
            {
                Console.Write(" {0}  ", stringarray[i]);

            }

        }
        public static void InsertionSort(string[] stringarray)
        {
            for (int j = 1; j < stringarray.Length; j++)
            {
                string key = stringarray[j];
                int i = j - 1;
                while (i >= 0)
                {
                    if (key.CompareTo(stringarray[i]) > 0)
                    {
                        break;
                    }
                    stringarray[i + 1] = stringarray[i];
                    i--;
                }
                stringarray[i + 1] = key;
                
            }
            //public static int[] CalculatePrimeNumbers(int[] prime)
            //{
            //    int flag=0,i;

            //    for (i=2;i<=prime.Length;i++)
            //    {
            //        for (int j = 2; j< i/ 2; j++)
            //        {

            //            if (i  % j == 0)
            //            {
            //                flag = 0;
            //                break;
            //            }

            //        }
            //        if (flag == 1)
            //        {
            //            Console.WriteLine(" " + i);
            //        }
            //    }

            //}

        }
    }
}
