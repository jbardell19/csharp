using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
	public class Board
	{
		public List<Checker> checkers;
		public Board()
		{
			checkers = new List<Checker>();
			for (int r = 0; r < 3; r++)
			{
				for (int i = 0; i < 8; i += 2)
				{
					Checker c = new Checker(Color.White, r, (r + 1) % 2 + i);
					checkers.Add(c);
				}
				for (int i = 0; i < 8; i += 2)
				{
					Checker c = new Checker(Color.Black, 5 + r, (r) % 2 + i);
					checkers.Add(c);
				}
			}
		}

		public Checker GetChecker(Position pos)
		{
			foreach (Checker c in checkers)
			{
				if (c.position.col == pos.col && c.position.row == pos.row)
					return c;
			}
			return null;
		}

		public void RemoveChecker(Checker checker)
		{
			if (checker != null)
			{
				checkers.Remove(checker);
			}
		}
		public void MoveChecker(Checker checker, Position dest)
		{
			Checker piecechecker = new Checker(checker.team, dest.row, dest.col);
			checkers.Add(piecechecker);
			RemoveChecker(checker);
		}
	}
}