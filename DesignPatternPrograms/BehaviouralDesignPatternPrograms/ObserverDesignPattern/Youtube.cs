using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehaviouralDesignPatternPrograms.ObserverDesignPattern
{
    public class Youtube
    {
        public void ImplementObserverPattern()
        {
            Channel telsko = new Channel();

            Subscriber firstSubscriber = new Subscriber("Amit");
            Subscriber secondSubscriber = new Subscriber("Meena");
            Subscriber thirdSubscriber = new Subscriber("Raj");
            Subscriber fourthSubscriber = new Subscriber("Sonali");
            Subscriber fifthSubscriber = new Subscriber("Leena");

            telsko.Subscribe(firstSubscriber);
            telsko.Subscribe(secondSubscriber);
            telsko.Subscribe(thirdSubscriber);
            telsko.Subscribe(fourthSubscriber);
            telsko.Subscribe(fifthSubscriber);

            telsko.UnSubscribe(fifthSubscriber);

            firstSubscriber.SubscribeChannel(telsko);
            secondSubscriber.SubscribeChannel(telsko);
            thirdSubscriber.SubscribeChannel(telsko);
            fourthSubscriber.SubscribeChannel(telsko);
            fifthSubscriber.SubscribeChannel(telsko);

            telsko.Upload("How to learn programming");
                
        }
    }
}
