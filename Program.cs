//using DataStructurePrograms.LinkedList;
using DataStructurePrograms.Dequeue;
using DataStructurePrograms.LinkedList;
using DataStructurePrograms.Queue;
using System;

namespace DataStructurePrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Data Structure Programs: \n\t1.Read File Search Word\n\t2.Read Numbers From File In Ascending Order\n\t3. Check BalancedParenthesis\n\t4.BankCounter\n\t5.Palindrome Checker\n\t6.Calculate Number of Possilble Binary Search Tree\n\t7.Hashing Function\n\t8.Insert PrimeNumbers In TwodimensionatArray\n\t9.Prime and Anagram\n\t10.exit");
                Console.Write("Enter Your Choice: ");
                int ch = Convert.ToInt32(Console.ReadLine());
                try
                {

                    switch (ch)
                    {
                        case 1:
                            LinkedListUtility.head = null;
                            UnorderedList unorderlist = new UnorderedList();
                            unorderlist.ReadSplitSerachWords();
                            break;

                        case 2:
                            OrderedUtility.orderhead = null;
                            OrderedList orderlist = new OrderedList();
                            orderlist.OrderListSearch();
                            break;

                        case 3:
                            BalancedParenthesis balanceparenthesis = new BalancedParenthesis();
                            balanceparenthesis.CheckExpressionBalancedOrNot();
                            break;
                        case 4:
                            BankingCashCounter bankcashtransaction = new BankingCashCounter();
                            bankcashtransaction.CashCounter();

                            break;
                        case 5:
                            PalindromeChecker palindromeobj = new PalindromeChecker();
                            palindromeobj.DisplayPalindromeStringOrNot();


                            break;
                        case 6:
                            BinarySearchTree numberofbinarysearchtree = new BinarySearchTree();
                            numberofbinarysearchtree.CalculateNumberOfTree();

                            break;
                        case 7:
                            HashingFunction hashfunction = new HashingFunction();
                            hashfunction.Hashing();

                            break;
                        case 8:
                            PrimeNumbersInTwoDimensionalArray primetwodimensional = new PrimeNumbersInTwoDimensionalArray();
                            primetwodimensional.InsertPrimeNumbersInTwoDimensionalArray();

                            break;
                        case 9:

                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }

                }
                catch (Exception )
                {
                    Console.WriteLine("Enter Choice Between 1 To 6");
                }
            }
        }
    }
}
