using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public struct Position
    {
        public int row { get; private set; }
        public int col { get; private set; }
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }
    public enum Color { White, Black }
    class Program
    {
        public static void Main(String[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Game game = new Game();
            game.Start();
            Console.ReadKey();
        }
    }
}