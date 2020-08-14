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
            ChessPosition chessPosition = new ChessPosition('c', 7);
            Console.WriteLine(chessPosition);

            Console.WriteLine(chessPosition.ToPosition());

        }
    }
}
