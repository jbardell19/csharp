using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
	public class Game
	{
		private Board board;
		public Game()
		{
			this.board = new Board();
		}
		private bool CheckForWin()
		{
			//the following code is using LINQ, you should research LINQ for future lessons :)
			return (board.checkers.All(x => x.team == Color.White) || board.checkers.All(x => x.team == Color.Black));
		}
		public void Start()
		{
			do
			{
				DrawBoard();
				ProcessInput();
			} while (!CheckForWin());
			Console.WriteLine("winner");
		}

		public bool IsLegalMove(Color player, Position src, Position dest)
		{

			if (src.row < 0 || src.row > 7 || (src.col) < 0 || (src.col) > 7
			   || dest.row < 0 || dest.row > 7 || (dest.col) < 0
			   || (dest.col) > 7) return false;

			int RowDistance = Math.Abs(dest.row - src.row);
			int ColDistance = Math.Abs(dest.col - src.col);
			if (ColDistance == 0 || RowDistance == 0) return (false);
			if (RowDistance / ColDistance != 1) return (false);
			if (RowDistance > 2) return (false);
			Checker c = board.GetChecker(src);
			if (c == null)
			{
				return false;
			}
			c = board.GetChecker(dest);
			if (c != null)
			{
				return false;
			}
			if (board.GetChecker(src) != null && board.GetChecker(dest) == null)
			{
				return true;
			}

			if (RowDistance == 2)
			{
				if (IsCapture(src, dest))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}

		}

		public bool IsCapture(Position src, Position dest)
		{
			int RowDistance = Math.Abs(dest.row - src.row);
			int ColDistance = Math.Abs(dest.col - src.col);

			if (RowDistance == 2 && ColDistance == 2)
			{
				int row_middle = (src.row + dest.row) / 2;
				int col_middle = (src.col + dest.col) / 2;
				Position P = new Position(row_middle, col_middle);
				Checker SChecker = board.GetChecker(src);
				Checker DChecker = board.GetChecker(P);

				if (SChecker.team != DChecker.team)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}
		}

		public Checker GetCaptureChecker(Position src, Position dest)
		{
			if (IsCapture(src, dest))
			{
				int row_middle = (src.row + dest.row) / 2;
				int col_middle = (src.col + dest.col) / 2;
				Position P = new Position(row_middle, col_middle);

				return board.GetChecker(P);
			}
			else
			{
				return null;
			}
		}

		public void ProcessInput()
		{
			Console.WriteLine("Which checker piece do you want to move? (row,column)");
			string[] InputFrom = (Console.ReadLine().Split(','));
			Position Source = new Position(int.Parse(InputFrom[0]), int.Parse(InputFrom[1]));
			Console.WriteLine("Where do you want to move your checker piece? (row, column)");
			string[] InputTo = (Console.ReadLine().Split(','));
			Position Destination = new Position(int.Parse(InputTo[0]), int.Parse(InputTo[1]));

			Checker SourceChecker = board.GetChecker(Source);
			if (IsLegalMove(SourceChecker.team, Source, Destination))
			{
				if (IsCapture(Source, Destination))
				{
					Checker Jumper = GetCaptureChecker(Source, Destination);
					board.RemoveChecker(Jumper);
					board.MoveChecker(SourceChecker, Destination);
				}
				board.MoveChecker(SourceChecker, Destination);

			}
			else
			{
				Console.WriteLine("not a legal move");
			}
			DrawBoard();


		}

		public void DrawBoard()
		{
			String[][] grid = new String[8][];
			for (int r = 0; r < 8; r++)
			{
				grid[r] = new String[8];
				for (int c = 0; c < 8; c++)
				{
					grid[r][c] = " ";
				}
			}
			foreach (Checker c in board.checkers)
			{
				grid[c.position.row][c.position.col] = c.symbol;
			}

			Console.WriteLine("  0 1 2 3 4 5 6 7");
			for (int r = 0; r < 8; r++)
			{
				Console.Write(r);
				for (int c = 0; c < 8; c++)
				{
					Console.Write(" {0}", grid[r][c]);
				}
				Console.WriteLine();
			}
		}

	}
}
