using System;

namespace DataStructurePrograms.LinkedList
{
    class LinkedListUtility
    {
        public static Node head;
        public static void Add(string d)
        {
            Node newNode = new Node(d);
            newNode.data = d;
            newNode.next = null;

            if (head == null)
                head = newNode;
            else
            {
                Node tempNode = head;
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = newNode;
            }
        }

        internal static void AddFirst(char item)
        {
            throw new NotImplementedException();
        }

        public static void InsertLast(string data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = new Node(data);
                return;
            }
            newNode.next = null;
            Node last = head;
            while (last.next != null)
            {
                last = last.next;
            }
            last.next = newNode;
        }

        public static void DeleteAtlast()
        {

            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Node temp = head;

                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;

            }
        }

        public static bool IsEmpty()
        {
            if (head == null)
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
            Node tempNode = head;
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
            Node tempNode = head;
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
            Node Unordedhead = null;
            Node tempNode = head;
            Node prevNode = head;
            bool found = false;
            while (tempNode != null)
            {
                if (tempNode.data.Equals(removeItem))
                {
                    if (tempNode == Unordedhead)
                    {
                        Unordedhead = Unordedhead.next;
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

        public static int Index(string searchItem)
        {
            Node tempNode =head;
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




        public static void AddFirst(string data)
        {
            Node newNode = new Node(data);
            newNode.data = data;
            if (head == null)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        /// <summary>
        /// Appends the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public static void Append(string data)
        {
            Node newNode = new Node(data);
            newNode.data = data;
            Node tempNode = head;
            try
            {
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }

                tempNode.next = newNode;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(" " + e);
            }
        }




        public static void InsertAtPos(int pos, string data)
        {
            Node newnode = new Node(data);

            if (head == null)
            {
                head = newnode;
            }
            else
            {
                Node prev = head;
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
            Node tempNode = head;
            Node prevNode = head;
            if (tempNode == null)
            {
                Console.WriteLine("UnderFlow");
            }
            else if (tempNode.next == null)
            {
                head = null;
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
            Node tempNode =head;
            Node prevNode = head;
            Node toCheckPosition = head;
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
        public static void Append(char data)
        {
            Node newNode = new Node(data);
            newNode.data = data;
            Node tempNode = head;
            try
            {
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }

                tempNode.next = newNode;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(" " + e);
            }
        }
        public static void Display()
        {
            Node tempNode = head;
            while (tempNode != null)
            {
                Console.Write(tempNode.data + "=>");
                tempNode = tempNode.next;
            }
        }

       
    }

}
