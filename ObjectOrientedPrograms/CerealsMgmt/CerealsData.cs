// <copyright file="CerealsData.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode "/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedProgramss.CerealsMgmt
{
    /// <summary>
    /// Cereals Data
    /// </summary>
    class CerealsData
    {
        private string name;
        private double price;
        private double weight;

        /// <summary>
        /// Gets or sets the data of Cereals
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public double Weight { get => weight; set => weight = value; }
    }
}
