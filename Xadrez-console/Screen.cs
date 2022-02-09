using System;
using Xadrez_console.Board;
using Xadrez_console.Board.Enums;

namespace Xadrez_console
{
    public class Screen
    {

        public static void ShowGameBoard(GameBoard gameBoard)
        {

            for (int i = 0; i < gameBoard.Lines; i++)
            {
                Console.Write($"{8 - i} ");
                for (int j = 0; j < gameBoard.Columns; j++)
                {
                    if(gameBoard.Piece(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Screen.ShowPiece(gameBoard.Piece(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");

        }

        static void ShowPiece(Piece piece)
        {
            if(piece.Color == Color.White)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
            
        }

    }
}
