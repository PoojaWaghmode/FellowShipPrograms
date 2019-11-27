using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehaviouralDesignPatternPrograms.MediatorDesignPattern
{
    class ChatRoom
    {
        public static void ShowMessage(User user,string message)
        {
            Console.WriteLine(new DateTime().TimeOfDay.ToString() + "[ "+user.GetName()+ "]:"+message);
        }
    }
}
