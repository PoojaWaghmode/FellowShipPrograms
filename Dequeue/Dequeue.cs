using DataStructurePrograms.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms.Dequeue
{
    public class Dequeue
    {
        /// <summary>
        /// This method add the item at first.
        /// </summary>
        /// <param name="item">it add item into queue</param>
        public static void AddFront(char item)
        {
            LinkedListUtility.AddFirst(item);
        }

        /// <summary>
        ///  This method add the item at last.
        /// </summary>
        /// <param name="item">it add item</param>
        public static void AddRear(string item)
        {
            LinkedListUtility.Append(item);
        }
        public static void AddRear(char item)
        {
            LinkedListUtility.Append(item);
        }


        public static void DequeueDisplay()
        {
            Node tempNode = LinkedListUtility.head;
            while (tempNode != null)
            {
                Console.WriteLine(tempNode.data + " ");
                tempNode = tempNode.next;
            }
        }
        /// <summary>
        ///  This method remove the item at first.
        /// </summary>
        public static void RemoveFront()
        {
            Node frontItem = LinkedListUtility.head;
            LinkedListUtility.head = LinkedListUtility.head.next;
        }
        
        /// <summary>
        /// This method check queue is empty or not.
        /// </summary>
        /// <returns>it return boolean value</returns>
        public static bool IsEmpty()
        {
            if (LinkedListUtility.IsEmpty())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// this method return size of queue.
        /// </summary>
        /// <returns>it return size</returns>
        public static int Size()
        {
            return LinkedListUtility.Size();
        }
    }
}

