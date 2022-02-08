using System;
using Xadrez_console.Board;
using Xadrez_console.Board.Enums;
using Xadrez_console.Xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            GameBoard gameBoard = new GameBoard(8, 8);
            gameBoard.PutPiece(new King(gameBoard, Color.White), new Position(0, 0));
            gameBoard.PutPiece(new King(gameBoard, Color.Black), new Position(2, 4));
            gameBoard.PutPiece(new Castle(gameBoard, Color.White), new Position(2, 2));


            Screen.ShowGameBoard(gameBoard);
            
        }
    }
}
