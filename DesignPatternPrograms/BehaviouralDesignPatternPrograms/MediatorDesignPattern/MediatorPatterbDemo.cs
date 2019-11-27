using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehaviouralDesignPatternPrograms.MediatorDesignPattern
{
    public class MediatorPatternbDemo
    {
        public void ImplementMadiatorPatternDemo()
        {
            User robert = new User("Robert");
            User john = new User("John");
            User henry = new User("Henry");
            robert.SendMessage("Hiiii i m robert");
            john.SendMessage("Hello i m john");
            henry.SendMessage("Hello...I am Henry");
        }
    }
}
