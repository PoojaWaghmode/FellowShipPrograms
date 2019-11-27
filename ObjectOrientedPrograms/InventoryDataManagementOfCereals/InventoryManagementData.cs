// <copyright file=" InventoryManagementData.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode "/>
// --------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramss.InventoryDataManagementOfCereals
{
    class InventoryManagementData
    {
        private List<Rice> riceList;
        private List<Wheat> wheatList;
        private List<Pulse> pulseList;

        public List<Rice> RiceList { get => riceList; set => riceList = value; }
        public List<Wheat> WheatList { get => wheatList; set => wheatList = value; }
        public List<Pulse> PulseList { get => pulseList; set => pulseList = value; }
    }
    class Rice
    {
        private string riceName;
        private double ricePrice;
        private double riceWeight;

        public string RiceName { get => riceName; set => riceName = value; }
        public double RicePrice { get => ricePrice; set => ricePrice = value; }
        public double RiceWeight { get => riceWeight; set => riceWeight = value; }
    }
    class Wheat
    {
        private string wheatName;
        private double wheatPrice;
        private double wheatWeight;

        public string WheatName { get => wheatName; set => wheatName = value; }
        public double WheatPrice { get => wheatPrice; set => wheatPrice = value; }
        public double WheatWeight { get => wheatWeight; set => wheatWeight = value; }
    }
    class Pulse
    {
        private string pulseName;
        private double pulsePrice;
        private double pulseWeight;

        public string PulseName { get => pulseName; set => pulseName = value; }
        public double PulsePrice { get => pulsePrice; set => pulsePrice = value; }
        public double PulseWeight { get => pulseWeight; set => pulseWeight = value; }
    }
}
