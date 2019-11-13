using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructurePrograms.LinkedList
{
    public class Node
     {
         public object data;

         public Node next;

         public Node(object d)
         {
             data = d;
             next = null;
         }

    }
    public class UnorderedList
    {

        public void ReadSplitSerachWords()
        {

            // Read and show each line from the file.
            string text = "";
            try
            {
                using (StreamReader streamreader = new StreamReader("C:\\Users\\User\\Desktop\\WordList.txt"))
                {
                    while ((text = streamreader.ReadLine()) != null)
                    {
                        string[] listarray = text.Split(' ');
                        foreach (string item in listarray)
                        {
                            LinkedListUtility.Add(item);
                            
                        }
                    }
                   
                }
                
                Console.Clear();
                Console.WriteLine(".....List Data....");
                LinkedListUtility.Display();

                Console.Write("\nEnter Word To Search In File:   ");
                string searchword = Console.ReadLine();

                if (LinkedListUtility.Search(searchword) == true)
                {
                 Console.Write("\nWord Found: " + searchword);
                 LinkedListUtility.Remove(searchword);
                 Console.WriteLine("Word Found So Remove From List Successfully..");
                }
                else
                {
                    Console.Write("\nNot Found Added In List");
                   LinkedListUtility.Add(searchword);

                    using (StreamWriter stream = new StreamWriter("C:\\Users\\User\\Desktop\\WordList.txt", true))
                    {
                        stream.Write(" "+searchword);
                    }
                    Console.Write("\nList Data Added Successfully.....\n");
                    Console.WriteLine("After Insert New Word In LinkedList:");
                   
                }
                
                LinkedListUtility.Display();
                Console.WriteLine("\n\n");
               
                
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e.Message);
            }


        }
        
      
    }


}





