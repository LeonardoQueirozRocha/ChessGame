﻿using ChessGame.board;

namespace ChessGame.chess
{
    class Tower : Piece
    {
        public Tower(Board board, Color color) : base(color, board) { }

        public override string ToString()
        {
            return "T";
        }
    }
}