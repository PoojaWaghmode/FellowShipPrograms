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
                Console.WriteLine(".....List Data....");
                LinkedListUtility.Display();

                Console.Write("\nEnter Word To Search In File:   ");
                string searchword = Console.ReadLine();

                if (LinkedListUtility.Search(searchword) == true)
                {
                 Console.Write("\nWord Found: " + searchword);
                 LinkedListUtility.Remove(searchword);
                 Console.WriteLine("Word Found So Remove From List Successfully..\n");

                    Node tempNode = LinkedListUtility.head;
                    string removedWord = "";
                    while (tempNode != null)
                    {
                        removedWord = removedWord + " " + tempNode.data;
                        tempNode = tempNode.next;
                    }
                    using (StreamWriter stream = new StreamWriter("C:\\Users\\User\\Desktop\\WordList.txt"))
                    {
                        stream.Write(removedWord);
                    }

                }
                else
                {
                    Console.Write("\nNot Found Added In List\n");
                    LinkedListUtility.Add(searchword);
                    Console.Write("\nList Data Added Successfully.....\n");
                    
                    Node tempNode = LinkedListUtility.head;
                    string addWord = "";
                    while (tempNode != null)
                    {
                        addWord = addWord + " " + tempNode.data;
                        tempNode = tempNode.next;
                    }
                    using (StreamWriter stream = new StreamWriter("C:\\Users\\User\\Desktop\\WordList.txt"))
                    {
                        stream.Write(addWord);
                    }

                   
                   
                }
                Console.WriteLine("After Insert New Word In LinkedList:");
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





