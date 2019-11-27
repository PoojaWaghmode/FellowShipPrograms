using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehaviouralDesignPatternPrograms.ObserverDesignPattern
{
    public interface InterfaceChannelSubject
    {
        void Subscribe(Subscriber subscriber);
        void UnSubscribe(InterfaceObserver subscriber);
        void NotifySubscribers();
        void Upload(string channelTitle);

    }
}
