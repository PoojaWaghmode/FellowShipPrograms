// <copyright file="Distance.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// -----------------------------------------------------------------------------------------------------------------
namespace Functional_Programs
{
    using System;
    class Distance
    {
        public void FindDistance()
        {
            Utility u = new Utility();
            Console.Write("Enter Value For X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value For Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
          
            Console.Write("\nDistance: " + u.calculateDistance(x, y));

        }

    }
}
