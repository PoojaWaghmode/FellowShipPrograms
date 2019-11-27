using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.CreationalDesignPatternPrograms.FactoryDesignPattern
{
    class TitaniumCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public TitaniumCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "Titanium";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }
        public override string CardType => throw new NotImplementedException();

        public override int CreditLimit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int AnnualCharge { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
