using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehaviouralDesignPatternPrograms.ObserverDesignPattern
{
    public interface InterfaceObserver
    {
        void Update();
        void SubscribeChannel(Channel channel);
    }
}
