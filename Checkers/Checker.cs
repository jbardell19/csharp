using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class Checker
    {
        public String symbol { get; private set; }
        public Color team { get; private set; }
        public Position position { get; set; }

        public Checker(Color Team, int row, int col)
        {
            int OpenCircleId = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
            int ClosedCircleId = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
            if (Color.Black == Team)
            {
                symbol = char.ConvertFromUtf32(ClosedCircleId);
                team = Color.Black;
            }
            else
            {
                symbol = char.ConvertFromUtf32(OpenCircleId);
                team = Color.White;
            }
            position = new Position(row, col);
        }

    }
}