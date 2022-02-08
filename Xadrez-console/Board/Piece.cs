
using Xadrez_console.Board.Enums;

namespace Xadrez_console.Board
{
    public abstract class Piece
    {

        public Position Posistion { get; set; }
        public Color Color { get; protected set; }
        public int Movements { get; protected set; }
        public GameBoard GameBoard { get; set; }

        public Piece(GameBoard gameBoard, Color color)
        {
            this.Posistion = null;
            this.Color = color;
            this.GameBoard = gameBoard;
        }
    }
}
