using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.CreationalDesignPatternPrograms.FactoryDesignPattern
{
    abstract class CreditCardFactory
    {
        public abstract CreditCard GetCreditCard();
    }
}
