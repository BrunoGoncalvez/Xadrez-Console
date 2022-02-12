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

            try
            {
                ChessGame chessGame = new ChessGame();
                
                while (!chessGame.Finish)
                {
                    Screen.ShowGameBoard(chessGame.GameBoard);

                    Console.WriteLine();

                    Console.Write("Origin: ");
                    Position origin = Screen.ReadPositionChess().ToPosition();

                    Console.Write("Destination: ");
                    Position destination = Screen.ReadPositionChess().ToPosition();

                    chessGame.ExecuteMovement(origin, destination);
                }

            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }

            
                       
        }

    }
}
