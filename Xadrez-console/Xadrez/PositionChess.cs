using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_console.Board;

namespace Xadrez_console.Xadrez
{
    public class PositionChess
    {

        public char Column { get; set; }
        public int Line { get; set; }


        public PositionChess(char column, int line)
        {
            this.Column = column;
            this.Line = line;
        }

        public Position ToPosition()
        {
            return new Position(8 - Line, Column - 'a');
        }

        public override string ToString()
        {
            return $"{Column}{Line}";
        }

    }
}
