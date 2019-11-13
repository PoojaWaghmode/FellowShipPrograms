using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class Gambler
    {
        public void PlayGambler()
        {
            Console.Write("Enter Stake Or Cash");
            int stake = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nSet Your Goal");
            int goal = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter How Many Times You Want To Play");
            int trials = Convert.ToInt32(Console.ReadLine());
            Utility.CalculationOfGambler(stake,goal,trials);

        }
    }
}
