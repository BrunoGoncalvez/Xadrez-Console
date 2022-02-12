using Xadrez_console.Board;
using Xadrez_console.Board.Enums;

namespace Xadrez_console.Xadrez
{
    public class King : Piece
    {

        public King(GameBoard gameBoard, Color color) : base(gameBoard, color)
        {
        }

        public override string ToString()
        {
            return "K";
        }

    }
}
