
using Xadrez_console.Board.Enums;

namespace Xadrez_console.Board
{
    public class Piece
    {

        public Position Posistion { get; set; }
        public Color Color { get; protected set; }
        public int Movements { get; protected set; }
        public Board Board { get; set; }

        public Piece(Position posistion, Color color, Board board)
        {
            Posistion = posistion;
            Color = color;
            Board = board;
        }
    }
}
