
using Xadrez_console.Board.Enums;

namespace Xadrez_console.Board
{
    public class Piece
    {

        public Position Posistion { get; set; }
        public Color Color { get; protected set; }
        public int Movements { get; protected set; }
        public GameBoard GameBoard { get; set; }

        public Piece(Position posistion, Color color, GameBoard board)
        {
            this.Posistion = posistion;
            this.Color = color;
            this.GameBoard = board;
        }
    }
}
