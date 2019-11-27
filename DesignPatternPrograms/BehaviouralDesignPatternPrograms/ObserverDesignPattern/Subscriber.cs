using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehaviouralDesignPatternPrograms.ObserverDesignPattern
{
    public class Subscriber :InterfaceObserver
    {
        private string subscriberName;
        private Channel channel=new Channel();

        public Subscriber(string subscriberName )
        {
            this.subscriberName = subscriberName;
        }

        public void Update()
        {
            Console.WriteLine("Hey "+subscriberName+" Vidio Updated"+channel.channelTitle);
        }
       
        public void SubscribeChannel(Channel channel)
        {
            channel = this.channel;
        }
    }
}
