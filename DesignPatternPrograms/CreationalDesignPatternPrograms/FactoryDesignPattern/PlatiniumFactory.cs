using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.CreationalDesignPatternPrograms.FactoryDesignPattern
{
    class PlatiniumFactory : CreditCardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public PlatiniumFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }
        public override CreditCard GetCreditCard()
        {
            return new PlatiniumCreditCard(_creditLimit, _annualCharge);
        }
    }
}
