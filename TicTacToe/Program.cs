﻿using System;
namespace TicTacToe
{

    class Program

    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int flag = 0;

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("Choose a number on the board.  X always goes first!");
                Console.WriteLine("\n");

                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2");
                }
                else
                { 
                    Console.WriteLine("Player 1");
                }
                Console.WriteLine("\n");
                Board();
                choice = int.Parse(Console.ReadLine());
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    switch (player % 2)
                    {
                        case 0:
                            arr[choice] = 'O';
                            player++;
                            break;
                        default:
                            arr[choice] = 'X';
                            player++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                }
                flag = CheckWin();
            } while (flag != 1 && flag != -1);
            Console.Clear();
            Board();
            switch (flag)
            {
                case 1:
                    Console.WriteLine("Game Over!! Player {0} has won!!", (player % 2) + 1);
                    break;
                default:
                    Console.WriteLine("Draw: This game ended in a tie");
                    break;
            }
            Console.ReadLine();
        }
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");

        }

        //Checking winning conditions//
        private static int CheckWin()
        { 
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }     
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Winning Conditions For Second Column // 
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            //Winning Conditions For Third Column // 
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            //Diagonal Winning Conditions//

            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}