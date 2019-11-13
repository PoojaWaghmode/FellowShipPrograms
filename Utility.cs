// <copyright file="Utility.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Logical_Programs
{
    using System;
    using System.Collections.Generic;

    class Utility
    {
        /// <summary>
        /// Calculations the of gambler.
        /// </summary>
        /// <param name="stake">The stake.</param>
        /// <param name="goal">The goal.</param>
        /// <param name="trials">The trials.</param>
        public static void CalculationOfGambler(int stake,int goal,int trials)
        {
            double loss = 0, win = 0,bet=0, percentofwin=0, percentloss=0;
            int cash = stake;
            for (int i = 0; i < trials; i++)
            {
                Random random = new Random();
                double random_no = random.NextDouble();
              
                if (cash > 0 && cash < goal)
                {
                    bet++;
                    if (random_no < 0.5)
                    {
                        cash++;
                        win++;
                    }
                    else
                    {
                        cash--;
                        loss++;
                    }
                    if (cash == 0 || cash>=goal)
                    {
                        break;
                    }
                }
            }
            percentofwin = win * 100 / bet;
            percentloss = loss * 100 / bet;
            Console.WriteLine("Win " + win);
            Console.WriteLine("Loss" + loss);
            Console.WriteLine("Bet" + bet);
            Console.WriteLine("Win Percentage :" + percentofwin);
            Console.WriteLine("Loss percentage:" + percentloss);

        }
        /// <summary>
        /// Calculates the elapsed time.
        /// </summary>
        /// <param name="start_time">The start time.</param>
        /// <param name="stop_time">The stop time.</param>
        /// <returns></returns>
        public double CalculateElapsedTime(double start_time, double stop_time)
        {
            
            double elapsedtime = stop_time - start_time;
            return elapsedtime;
        }
        /// <summary>
        /// Gets the copoun.
        /// </summary>
        /// <param name="keys">The keys.</param>
        /// <param name="distinct_no">The distinct no.</param>
        /// <returns></returns>
        public static char[] GetCopoun( string keys,int distinct_no)
        {
            HashSet<string> hashset = new HashSet<string>();
            string str = "";
            ////Use Random Class for generating random numbers and create object of it 
            Random r = new Random();
            ////Create character array of length which u want to create coupoun No.
            char[] CoupounNo = new char[distinct_no];
            ////Repeat loop upto entered distinct_No
            for (int i = 0; i < distinct_no; i++)
            {
                //From string keys take each character randomly and store it in character array CoupounNo[]
                CoupounNo[i] = keys[(r.Next(keys.Length))];
                str = str + CoupounNo[i];
            }  
            ////Return generated unique coupoun No 
            return CoupounNo;
        }
        /// <summary>
        /// Draws the board.
        /// </summary>
        /// <param name="pos">The position.</param>
        public static void DrawBoard(string[] pos) // Draw board method ==========================================
        {
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[1], pos[2], pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[4], pos[5], pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[7], pos[8], pos[9]);
        }
        public static bool CheckWin(string[] pos) // Win checker method ================================================
        {
            if (pos[1] == "O" && pos[2] == "O" && pos[3] == "O") // Horizontal ----------------------------------------
            {
                return true;
            }
            else if (pos[4] == "O" && pos[5] == "O" && pos[6] == "O")
            {
                return true;
            }
            else if (pos[7] == "O" && pos[8] == "O" && pos[9] == "O")
            {
                return true;
            }

            else if (pos[1] == "O" && pos[5] == "O" && pos[9] == "O") // Diagonal -----------------------------------------
            {
                return true;
            }
            else if (pos[7] == "O" && pos[5] == "O" && pos[3] == "O")
            {
                return true;
            }

            else if (pos[1] == "O" && pos[4] == "O" && pos[7] == "O")// Coloumns ------------------------------------------
            {
                return true;
            }
            else if (pos[2] == "O" && pos[5] == "O" && pos[8] == "O")
            {
                return true;
            }
            else if (pos[3] == "O" && pos[6] == "O" && pos[9] == "O")
            {
                return true;
            }

            if (pos[1] == "X" && pos[2] == "X" && pos[3] == "X") // Horizontal ----------------------------------------
            {
                return true;
            }
            else if (pos[4] == "X" && pos[5] == "X" && pos[6] == "X")
            {
                return true;
            }
            else if (pos[7] == "X" && pos[8] == "X" && pos[9] == "X")
            {
                return true;
            }

            else if (pos[1] == "X" && pos[5] == "X" && pos[9] == "X") // Diagonal -----------------------------------------
            {
                return true;
            }
            else if (pos[7] == "X" && pos[5] == "X" && pos[3] == "X")
            {
                return true;
            }

            else if (pos[1] == "X" && pos[4] == "X" && pos[7] == "X") // Coloumns ------------------------------------------
            {
                return true;
            }
            else if (pos[2] == "X" && pos[5] == "X" && pos[8] == "X")
            {
                return true;
            }
            else if (pos[3] == "X" && pos[6] == "X" && pos[9] == "X")
            {
                return true;
            }
            else // No winner ----------------------------------------------
            {
                return false;
            }
        }
    }
}

