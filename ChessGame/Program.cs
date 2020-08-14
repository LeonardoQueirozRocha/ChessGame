using System;
using System.Reflection.PortableExecutable;
using ChessGame.board;
using ChessGame.chess;
using Microsoft.VisualBasic;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessMatch chessMatch = new ChessMatch();

                while (!chessMatch.finished)
                {
                    Console.Clear();
                    Screen.PrintTray(chessMatch.Board);

                    Console.Write("\nOrigin: ");
                    Position origin = Screen.ReadChessPosition().ToPosition();

                    Console.Write("Destiny: ");
                    Position destiny = Screen.ReadChessPosition().ToPosition();

                    chessMatch.ExecuteMoviment(origin, destiny);
                }

                Screen.PrintTray(chessMatch.Board);
            }
            catch (BoardException error)
            {
                Console.WriteLine(error.Message);
            }
            Console.ReadLine();
        }
    }
}
