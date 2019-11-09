using System;
using System.Collections.Generic;

namespace towersOfHanoi
{
    class Program
    {
        private static List<List<int>> board = new List<List<int>>();
        public static List<List<int>> Board { get => board; set => board = value; }
        static void Main(string[] args)
        {
            FirstBoard();
            do
            {
                DrawBoard();
                GetUserSelection();
            } while (!GameWin);
            Console.ReadKey();
        }
        public static void FirstBoard()
        {   
            List<int> row1 = new List<int>(4);
            List<int> row2 = new List<int>(4);
            List<int> row3 = new List<int>(4);
            for (int i = 4; i > 0; i--)
            {
                row1.Add(i);
            }
            board.Add(row1);
            board.Add(row2);
            board.Add(row3);
        }
        public static void GetUserSelection()
            //user selction and movement//
        {
            Console.WriteLine("Which row do you want to move from?");
            int pieceFrom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Which row do you want to move to? 1 ,2, or 3?");
            int pieceTo = Convert.ToInt32(Console.ReadLine());
            followRules(pieceFrom, pieceTo);
        }
        public static void followRules(int pieceFrom, int pieceTo)
        {
            int movingToRow = pieceTo - 1;
            int movingFromRow = pieceFrom - 1;
            int movingFromIndex = Board[movingFromRow].Count - 1;
            int movingToIndex;
            int movingToPiece;
            int movingFromPiece = Board[movingFromRow][movingFromIndex]; 
            if (Board[movingToRow].Count == 0)
            {
                movingToIndex = 0;
                Board[movingToRow].Add(movingFromPiece);
                movingToPiece = Board[movingToRow][movingToIndex];
                Board[movingFromRow].RemoveAt(movingFromIndex);
            }
            else
            {
                movingToIndex = Board[movingToRow].Count;
                movingToPiece = Board[movingToRow][movingToIndex - 1];
                if ((Board[movingFromRow].Count != 0 && movingFromPiece < movingToPiece))
                {
                    Board[movingToRow].Add(movingFromPiece);
                    Board[movingFromRow].RemoveAt(movingFromIndex);
                }
            }
            if (movingFromPiece > movingToPiece)
            {
                Console.WriteLine("YOU CAN'T DO THAT! TRY AGAIN!!");
            }
        }
        public static bool GameWin
        {
            get
            {
                if (Board[2].Count == 4)
                {
                    Console.WriteLine("You Won!");
                    return true;
                }
                return false;
            }
        }
        public static void DrawBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write((i + 1) + ":");
                for (int j = 0; j < Board[i].Count; j++)
                {
                    Console.Write(Board[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
