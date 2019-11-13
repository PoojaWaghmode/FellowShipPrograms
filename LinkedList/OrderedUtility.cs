using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms.LinkedList
{
    public class OrderedUtility
    {
        public static OrderedNode orderhead;
        public static OrderedNode AddOrder(int data)
        {
            OrderedNode newNode = new OrderedNode(data);
            newNode.data = data;
            OrderedNode current = orderhead;
            if (orderhead == null || orderhead.data >= newNode.data)
            {
                newNode.next = orderhead;
                orderhead = newNode;
            }
            else
            {
                current = orderhead;
                while (current.next != null &&
                    current.next.data < newNode.data)
                {
                    current = current.next;
                }

                newNode.next = current.next;
                current.next = newNode;
            }

            return newNode;
        }




        public static void DeleteAtlast()
        {

            if (orderhead == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                OrderedNode temp = orderhead;

                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;

            }
        }

        public static bool IsEmpty()
        {
            if (orderhead == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int Size()
        {
            OrderedNode tempNode = orderhead;
            int size = 0;
            while (tempNode != null)
            {
                size++;
                tempNode = tempNode.next;
            }

            return size;
        }


        public static bool Search(object searchItem)
        {
            OrderedNode tempNode = orderhead;
            while (tempNode != null)
            {
                if (tempNode.data.Equals(searchItem))
                {
                    return true;
                }

                tempNode = tempNode.next;
            }

            return false;
        }
        public static void Remove(object removeItem)
        {
            OrderedNode tempNode = orderhead;
            OrderedNode prevNode = orderhead;
            bool found = false;
            while (tempNode != null)
            {
                if (tempNode.data.Equals(removeItem))
                {
                    if (tempNode == orderhead)
                    {
                        orderhead = orderhead.next;
                        return;
                    }

                    prevNode.next = tempNode.next;
                    found = true;
                    break;
                }

                prevNode = tempNode;
                tempNode = tempNode.next;
            }

            if (!found)
            {
                Console.WriteLine("Your Item Is Not Present In The List");
                Console.WriteLine("\nEnter Item Again For Remove : ");
                string data = Console.ReadLine();
                removeItem = (object)Convert.ChangeType(data, typeof(object));
                Remove(removeItem);
            }
        }

        public static int Index(int searchItem)
        {
            OrderedNode tempNode = orderhead;
            int index = 0;
            while (tempNode != null)
            {
                if (tempNode.data.Equals(searchItem))
                {
                    return index;
                }

                tempNode = tempNode.next;
                index++;
            }

            return -1;
        }








        public static void InsertAtPos(int pos, int data)
        {
            OrderedNode newnode = new OrderedNode(data);

            if (orderhead == null)
            {
                orderhead = newnode;
            }
            else
            {
                OrderedNode prev = orderhead;
                for (int i = 0; i < pos - 1; i++)
                {
                    prev = prev.next;
                }
                newnode.next = prev.next;
                prev.next = newnode;
            }

        }
        public static void Pop()
        {
            OrderedNode tempNode = orderhead;
            OrderedNode prevNode = orderhead;
            if (tempNode == null)
            {
                Console.WriteLine("UnderFlow");
            }
            else if (tempNode.next == null)
            {
                orderhead = null;
            }
            else
            {
                while (tempNode.next != null)
                {
                    prevNode = tempNode;
                    tempNode = tempNode.next;
                }

                prevNode.next = null;
            }
        }
        public static object Pop(int position)
        {
            OrderedNode tempNode = orderhead;
            OrderedNode prevNode = orderhead;
            OrderedNode toCheckPosition = orderhead;
            int pos = 0;
            int count = 1;
            bool isValidePosition = false;
            while (toCheckPosition != null)
            {
                if (pos == position)
                {
                    isValidePosition = true;
                    break;
                }

                pos++;
                toCheckPosition = toCheckPosition.next;
            }

            if (isValidePosition)
            {
                while (tempNode.next != null)
                {
                    if (count == position)
                    {
                        break;
                    }

                    count++;
                    prevNode = tempNode;
                    tempNode = tempNode.next;
                }

                prevNode.next = tempNode.next;
                tempNode.next = null;
                return tempNode.data;
            }
            else
            {
                Console.WriteLine("Please Enter Valide Position ");
                Console.WriteLine("\nPlease Enter New  Position :");
                position = Convert.ToInt32(Console.ReadLine());
                return Pop(position);
            }
        }
        /* public static Node pop(int position)
         {
             Node current = head;
             int count = 0;
             string item = null;
             while (current != null)
             {
                 if (count == position)
                 {
                     item = current.data;
                     current=null;
                 }
                 else
                 {
                     count++;
                     current.next;
                 }
             }






















             return item;
         }*/

        public static void Display()
        {
            OrderedNode tempNode = orderhead;
            while (tempNode != null)
            {
                Console.WriteLine(tempNode.data + " ");
                tempNode = tempNode.next;
            }
        }


    }
}

