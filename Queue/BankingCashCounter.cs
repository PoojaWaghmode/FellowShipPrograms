using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms.Queue
{
    public class BankingCashCounter
    {
        /// <summary>
        /// Cash the counter.
        /// </summary>
        public void CashCounter()
        {
            long bankBalance = 1000000;
            Console.WriteLine(".....BridgeLabz Bank.......");
            Console.WriteLine("Available Balance Is: "+bankBalance);
            Console.Write("\nEnter How Many Peoples Want To Add In Queue");
            int numberofpeople = Convert.ToInt32(Console.ReadLine());
            Queue queue = new Queue(numberofpeople);
           
            ////loop iterates until how many peoples
            for (int i = 1; i <= numberofpeople; i++)
            {
                Console.WriteLine("User"+i+":");

                ////insert the elements in the queue
                queue.Enqueue(i);

            }

            if (numberofpeople > 0)
            {
                for (int i = 1; i <= numberofpeople; i++)
                {
                    Console.WriteLine("........Transactions......");
                    Console.Write("\nPress Key : \n\t 1. for Deposit \n 2. for Withdraw:\n");
                    int key = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Transaction Of User" + i + ":");
                    queue.Dequeue();
                    if (key == 1)
                    {
                        
                        Console.Write("\nEnter total amount do you want to deposit:");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        if (deposit > 0)
                        {
                            queue.Enqueue(deposit);
                            Console.WriteLine("Deposit Successfully....");
                            bankBalance = bankBalance + deposit;
                            Console.WriteLine("Total balance is:" + bankBalance);
                        }
                        else
                        {
                            Console.WriteLine("Please enter amount greater than 0");
                        }
                    }
                    else if (key == 2)
                    {
                        Console.WriteLine("Enter total amount do you want to withdrow");
                        int withdrow = Convert.ToInt32(Console.ReadLine());
                        if (bankBalance >= withdrow)
                        {
                            Console.WriteLine("Withdrow Successfully...");
                            bankBalance = bankBalance - withdrow;
                            Console.WriteLine("Toatal Balance is : " + bankBalance);
                            queue.QueueDisplay();
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Insure that you enter correct key");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
