using DataStructurePrograms.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    public class HashingFunction
    {
        /// <summary>
        /// Hashing this instance.
        /// </summary>
        public void Hashing()
        {
            
            OrderedNode[][] lists = new OrderedNode[10][];
            int[] a = { 11, 12, 13, 14, 15, 16, 22, 23, 19, 33, 32 };

            for (int k = 0; k < 10; k++)
            {
                lists[k] = new OrderedNode[10];
            }

            for (int j = 0; j < 10; j++)
            {
                int rem = a[j] % 11;
                if (rem == j)
                {
                    for (int o = 0; o < 5; o++)
                    {
                        if (lists[j][o] == null)
                        {
                            lists[j][o] = OrderedUtility.AddOrder(a[j]);
                            break;
                        }
                    }
                }
            }

            for (int k = 0; k < 10; k++)
            {
                try
                {
                    Console.Write(" list {0}", k);
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write("  " + lists[k][j].data);
                    }

                    Console.WriteLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception");
                }
            }
        }
    }
}
