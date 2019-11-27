using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.CreationalDesignPatternPrograms.SingltonDesignPatternPrograms
{
    /// <summary>
    /// Singlton Class
    /// </summary>
    public class EcommerceApplication
    {
        public void DisplayDetails()
        {
            Console.WriteLine("....Welcome....");
        }
    }
    public sealed class UserLogin:EcommerceApplication
        {
            private static int counter = 0;
            private static UserLogin newUserId = null;
        
           
            public static UserLogin getInstance()
            {
           
            if (newUserId == null)
                {
                
                    newUserId = new UserLogin();
                }
               
                return newUserId;
            }
            private UserLogin()
            {
                counter++;
                Console.WriteLine("Counter Value:" + counter.ToString());
            }

            public void PrintDetails(string message)
            {
            DisplayDetails();
            Console.WriteLine(message);
            
            }
            

        }
    
}
