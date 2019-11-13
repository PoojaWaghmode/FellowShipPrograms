using DataStructurePrograms.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms.Dequeue
{
    public class PalindromeChecker
    {
        public void DisplayPalindromeStringOrNot()
        {
            Console.WriteLine("Enter String:");
            string orignalstring = Console.ReadLine();


            //calling isPalindrome method.
            bool result = isPalindrome(orignalstring);

            if (result)
            {
                Console.WriteLine("String is palindrome.");
            }
            else
            {
                Console.WriteLine("String is not palindrome.");
            }
        }
        public static bool isPalindrome(String originalstring)
        {
            //for loop for add string into deque.
            for (int i = 0; i < originalstring.Length; i++)
            {
                char ch = originalstring[i];
                Dequeue.AddRear(ch);
                Console.WriteLine(ch);
            }

            String temp = "";

            //for loop for remove string from deque
            for (int i = 0; i < originalstring.Length; i++)
            {
                Dequeue.RemoveFront();
            }
            Dequeue.DequeueDisplay();
            //string is palindrome or not
            if (originalstring.Equals(temp))
            {
                return true;
            }

            return false;
        }



    }

}
