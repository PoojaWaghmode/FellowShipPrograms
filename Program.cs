using System;

namespace Logical_Programs
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                try
                {

                    Console.WriteLine("\n Logical Programs:\n\t1.Play Gambler \n\t2.Coupoun Number\n\t3.Stop Watch\n\t4.Play Tic_Tac_Toe\n\t5.Exit\n\n");
                    Console.Write("Enter Your Choice: ");
                    int ch = Convert.ToInt32(Console.ReadLine());

                    switch (ch)
                    {
                        case 1:
                            Gambler gambler = new Gambler();
                            gambler.PlayGambler();
                            break;
                        case 2:
                            CouponNumber coupounno = new CouponNumber();
                            coupounno.FindCoupounNumber();
                            break;
                        case 3:
                            StopWatch st = new StopWatch();
                            st.FindElapsedTime();
                            break;
                        case 4:
                            Tic_Tac_Toe_Game t3 = new Tic_Tac_Toe_Game();
                            t3.PlayTicTacToe();
                            break;
                       
                        case 5:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine(" Invalid Input Enter Choice Between 1 To 7");
                }
            }

        }
    }
}
