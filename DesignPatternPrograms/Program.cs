using DesignPatternPrograms.BehaviouralDesignPatternPrograms.ObserverDesignPattern;
using DesignPatternPrograms.CreationalDesignPatternPrograms.FactoryDesignPattern;
using DesignPatternPrograms.CreationalDesignPatternPrograms.PrototypeDesignPattern;
using DesignPatternPrograms.CreationalDesignPatternPrograms.SingltonDesignPatternPrograms;
using DesignPatternPrograms.BehaviouralDesignPatternPrograms.MediatorDesignPattern;
using System;

namespace DesignPatternPrograms
{
    class Program
    {
        public static object EcommerceApplicationUser { get; private set; }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("1.Singlton\n 2.Factory\n 3. \n7.Observer");
                Console.WriteLine("Enter Your Choice:");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        SingltonClass singltonObject = new SingltonClass();
                        singltonObject.DisplaySingltonClass();
                        break;
                    case 2:
                        ClientApplication clientapplication = new ClientApplication();
                        clientapplication.ImplementFactoryDesignPattern();
                        break;
                    case 3:
                        PrototypePatternDemo prototype = new PrototypePatternDemo();
                        prototype.ImplementPrototype();
                        break;
                    case 4:
                        Youtube youtube = new Youtube();
                        youtube.ImplementObserverPattern();
                        break;
                    case 5:
                        MediatorPatternbDemo mediatordesignpattern = new MediatorPatternbDemo();
                        mediatordesignpattern.ImplementMadiatorPatternDemo();
                        break;


                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
           


        }
    }
   
}
