using System;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;
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

                    Console.WriteLine();
                    Console.Write("\nOrigin: ");
                    Position origin = Screen.ReadChessPosition().ToPosition();

                    bool[,] possiblePositions = chessMatch.Board.piece(origin).PossibleMovements();

                    Console.Clear();
                    Screen.PrintTray(chessMatch.Board, possiblePositions);

                    Console.WriteLine();
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
