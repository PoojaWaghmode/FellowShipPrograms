    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

namespace DataStructurePrograms.LinkedList
{
    public class OrderedNode
    {
        public int data;

        public OrderedNode next;

        public OrderedNode(int d)
        {
            data = d;
            next = null;
        }


    }
    class OrderedList
    {

        public void OrderListSearch()
        {
            StreamReader streamreader = new StreamReader("C:\\Users\\User\\Desktop\\NumberList.txt");
            string text;
            while ((text = streamreader.ReadLine()) != null)
            {
                string[] stringArray = text.Split(' ');
                foreach (string item in stringArray)
                {
                    int number = 0;
                    int.TryParse(item, out number);
                    OrderedUtility.AddOrder(number);
                }
            }


            OrderedUtility.Display();
            Console.Write("\nEnter Number To Search");
            int itemsearch = Convert.ToInt32(Console.ReadLine());
            if (OrderedUtility.Search(itemsearch) == true)
            {
                Console.Write("\nNumber Found:  " + itemsearch);

                OrderedUtility.Remove(itemsearch);
                Console.Write("\n..Removed Number Successfully..\n");
            }
            else
            {
                Console.Write("\nNumber Not Found:  " + itemsearch + "\n");
                Console.WriteLine("After Insert New Number In LinkedList:");
                OrderedUtility.AddOrder(itemsearch);
                Console.WriteLine("Numbers In Ascending Order:");
               
            }
            OrderedUtility.Display();
           

        }

        //// streamreader.Close();
    }
}
      
