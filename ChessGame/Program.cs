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
                Board board = new Board(8, 8);

                board.PutPiece(new Tower(board, Color.Black), new Position(0, 0));
                board.PutPiece(new Tower(board, Color.Black), new Position(1, 9));
                board.PutPiece(new King(board, Color.Black), new Position(0, 2));

                Screen.PrintTray(board);
            }
            catch (BoardException error)
            {
                Console.WriteLine(error.Message);
            }
            Console.ReadLine();
        }
    }
}
