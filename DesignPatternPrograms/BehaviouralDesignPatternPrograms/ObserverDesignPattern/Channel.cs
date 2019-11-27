using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehaviouralDesignPatternPrograms.ObserverDesignPattern
{
    public class Channel :InterfaceChannelSubject

    {
        private List<InterfaceObserver> subscribers = new List<InterfaceObserver>();
        public string channelTitle;
        public void Subscribe(Subscriber subscriber)
        {
            subscribers.Add(subscriber);
        }
        public void UnSubscribe(InterfaceObserver subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach(InterfaceObserver subscriber in subscribers)
            {
                subscriber.Update();
            }
        }
        public void Upload(String channelTitle)
        {
            this.channelTitle = channelTitle;
            NotifySubscribers();
        }

    }
}
