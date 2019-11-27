using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehaviouralDesignPatternPrograms.MediatorDesignPattern
{
    public class User
    {
        private string name;
       
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public User(string name)
        {
            this.name = name;
        }
        public void SendMessage(string message)
        {
            ChatRoom.ShowMessage(this,message);
        }
    }
}
