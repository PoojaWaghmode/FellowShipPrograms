using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class Tic_Tac_Toe_Game
    {
        public void PlayTicTacToe()
        {
            string[] pos = new string[10] { "0","1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string player1 = "", player2 = "";
            int choice = 0, turn = 1, score1 = 0, score2 = 0;
            bool winFlag = false, playing = true, correctInput = false;
            Utility.DrawBoard(pos);
            Console.WriteLine("Hello! This is Tic Tac Toe. If you don't know the rules then stop being an idiot.");
            Console.WriteLine("What is the name of player 1?");
            player1 = Console.ReadLine();
            Console.WriteLine("Very good. What is the name of player 2?");
            player2 = Console.ReadLine();
            Console.WriteLine("Okay good. {0} is O and {1} is X.", player1, player2);
            Console.WriteLine("{0} goes first.", player1);
            Console.ReadLine();
           
        }
    }
}
