using Xadrez_console.Board;
using Xadrez_console.Board.Enums;

namespace Xadrez_console.Xadrez
{
    public class Castle : Piece
    {

        public Castle(GameBoard gameBoard, Color color) : base(gameBoard, color)
        {
        }

        public override string ToString()
        {
            return "T";
        }

    }
}
