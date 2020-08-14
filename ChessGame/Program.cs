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
                board.PutPiece(new Tower(board, Color.Black), new Position(1, 3));
                board.PutPiece(new King(board, Color.Black), new Position(0, 2));

                board.PutPiece(new Tower(board, Color.White), new Position(3, 5));



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
