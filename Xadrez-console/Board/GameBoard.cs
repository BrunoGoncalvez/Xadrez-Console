
using Xadrez_console.Exceptions;

namespace Xadrez_console.Board
{
    public class GameBoard
    {

        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces;

        public GameBoard(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            Pieces = new Piece[lines, columns];
        }

        public Piece Piece(int line, int column)
        {
            return Pieces[line, column];
        }

        public Piece Piece(Position position)
        {
            return Pieces[position.Line, position.Column];
        }

        public void PutPiece(Piece piece, Position position)
        {
            if (ExistPiece(position))
            {
                throw new BoardException("There is already a piece in that position.");
            }
            Pieces[position.Line, position.Column] = piece;
            piece.Posistion = position;
        }

        public Piece OutPiece(Position position)
        {
            if(Piece(position) == null)
            {
                return null;
            }
            Piece aux = Piece(null);
            aux.Posistion = null;
            Pieces[position.Line, position.Column] = null;
            return aux;
        }

        public bool ExistPiece(Position position)
        {
            ValidatePosition(position);
            return Piece(position) != null;
        }

        public bool CheckPosition(Position position)
        {
            if(position.Line < 0 || position.Column >= Lines || position.Column < 0 || position.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position position)
        {
            if (!CheckPosition(position))
            {
                throw new BoardException("Invalid Position.");
            }
        }


    }
}
