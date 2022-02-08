using System;
using Xadrez_console.Board;
namespace Xadrez_console
{
    public class Screen
    {

        public static void ShowGameBoard(GameBoard gameBoard)
        {

            for (int i = 0; i < gameBoard.Lines; i++)
            {
                for (int j = 0; j < gameBoard.Columns; j++)
                {
                    if(gameBoard.Piece(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(gameBoard.Piece(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }

        }

    }
}
