using System;

namespace Algorithm_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("\n\nAlgorithm Programs: \n\t1.Permutations Of String\n\t2. Binary Search the Word from Word List \n\t3. Insertion Sort For Strings\n\t4.Bubble Sort\n\t5.Merge Sort of list of Strings\n\t6. Anagram Detection \n\t7.Find Prime Numbers Between Range 1 to 1000\n\t8.Find Prime Numbers and Find anagram and palindrome No.\n\t9.Question To Find Number In Mind\n\t10.exit\n\n");
                    Console.Write("Enter Your Choice: ");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            
                            break;
                        case 2:
                            
                            break;
                        case 3:
                            InsertionSort insertsort = new InsertionSort();
                            insertsort.StringSort();
                            break;
                        case 4:
                            BubbleSort b_sort = new BubbleSort();
                            b_sort.Sort();
                            break;
                        case 5:
                           
                            break;
                        case 6:
                            
                            break;
                        case 7:
                            PrimeNumbers primeno = new PrimeNumbers();
                            primeno.FindPrimeNumbers();
                            break;
                        case 8:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine(" Invalid Input Enter Choice Between 1 To 7");
                }
            }
        }

    }
}

