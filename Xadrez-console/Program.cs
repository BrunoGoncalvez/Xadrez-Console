using System;
using Xadrez_console.Board;
using Xadrez_console.Board.Enums;
using Xadrez_console.Exceptions;
using Xadrez_console.Xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            GameBoard gameBoard = new GameBoard(8, 8);
            GameBoard(gameBoard);
            Screen.ShowGameBoard(gameBoard);

            PositionChess positionChess = new PositionChess('c', 7);
            Console.WriteLine(positionChess);

            Console.WriteLine(positionChess.ToPosition());
                       
        }

        static void GameBoard(GameBoard gameBoard)
        {
            try
            {
                gameBoard.PutPiece(new King(gameBoard, Color.White), new Position(0, 0));
                gameBoard.PutPiece(new King(gameBoard, Color.White), new Position(2, 4));
                gameBoard.PutPiece(new Castle(gameBoard, Color.White), new Position(7, 7));
            }
            catch (BoardException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
