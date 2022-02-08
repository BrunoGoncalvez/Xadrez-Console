using System;
using Xadrez_console.Board;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            GameBoard gameBoard = new GameBoard(8, 8);
            Screen.ShowGameBoard(gameBoard);
            

        }
    }
}
