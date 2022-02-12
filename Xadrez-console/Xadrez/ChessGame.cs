using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_console.Board;
using Xadrez_console.Board.Enums;

namespace Xadrez_console.Xadrez
{
    public class ChessGame
    {

        public GameBoard GameBoard { get; private set; }
        private int Round;
        private Color CurrentPlayer; 
        public bool Finish { get;private set; }
        
        public ChessGame()
        {
            this.GameBoard = new GameBoard(8, 8);
            this.Round = 1;
            this.CurrentPlayer = Color.White;
            this.Finish = false;
            PutPieces();
        }

        public void ExecuteMovement(Position origin, Position destination)
        {
            Piece p = GameBoard.OutPiece(origin);
            p.InceaseMovements();
            Piece capturePiece = GameBoard.OutPiece(destination);
            GameBoard.PutPiece(p, destination);
        }

        private void PutPieces()
        {
            GameBoard.PutPiece(new Castle(GameBoard, Color.White), new PositionChess('c',1).ToPosition());
            GameBoard.PutPiece(new Castle(GameBoard, Color.White), new PositionChess('c',2).ToPosition());
            GameBoard.PutPiece(new Castle(GameBoard, Color.White), new PositionChess('d',2).ToPosition());
            GameBoard.PutPiece(new Castle(GameBoard, Color.White), new PositionChess('e',2).ToPosition());
            GameBoard.PutPiece(new Castle(GameBoard, Color.White), new PositionChess('e',1).ToPosition());
            GameBoard.PutPiece(new King(GameBoard, Color.White), new PositionChess('d',1).ToPosition());

            GameBoard.PutPiece(new Castle(GameBoard, Color.Black), new PositionChess('c', 7).ToPosition());
            GameBoard.PutPiece(new Castle(GameBoard, Color.Black), new PositionChess('c', 8).ToPosition());
            GameBoard.PutPiece(new Castle(GameBoard, Color.Black), new PositionChess('d', 7).ToPosition());
            GameBoard.PutPiece(new Castle(GameBoard, Color.Black), new PositionChess('e', 7).ToPosition());
            GameBoard.PutPiece(new Castle(GameBoard, Color.Black), new PositionChess('e', 8).ToPosition());
            GameBoard.PutPiece(new King(GameBoard, Color.Black), new PositionChess('d', 8).ToPosition());
        }


    }
}
