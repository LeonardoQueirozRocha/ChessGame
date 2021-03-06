﻿using ChessGame.board;
using System.Dynamic;

namespace ChessGame.board
{
    abstract class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MovementsQuantity { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Color color, Board board)
        {
            Position = null;
            Color = color;
            Board = board;
            MovementsQuantity = 0;
        }

        public abstract bool[,] PossibleMovements();

        public void IncrementQuantityMovements()
        {
            MovementsQuantity++;
        }
    }
}
