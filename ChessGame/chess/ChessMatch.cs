using System;
using ChessGame.board;

namespace ChessGame.chess
{
    class ChessMatch
    {
        public Board Board { get; private set; }
        private int _shift;
        private Color _currentPlayer;
        public bool finished { get; private set; }

        public ChessMatch()
        {
            Board = new Board(8, 8);
            _shift = 1;
            _currentPlayer = Color.White;
            finished = false;
            PutPieces();
        }

        public void ExecuteMoviment(Position origin, Position destiny)
        {
            Piece piece = Board.WithdrawPiece(origin);
            piece.IncrementQuantityMovements();
            Piece capturedPiece = Board.WithdrawPiece(destiny);
            Board.PutPiece(piece, destiny);
        }

        public void PutPieces()
        {

            Board.PutPiece(new Tower(Board, Color.White), new ChessPosition('c', 1).ToPosition());
            Board.PutPiece(new Tower(Board, Color.White), new ChessPosition('c', 2).ToPosition());
            Board.PutPiece(new Tower(Board, Color.White), new ChessPosition('d', 2).ToPosition());
            Board.PutPiece(new Tower(Board, Color.White), new ChessPosition('e', 2).ToPosition());
            Board.PutPiece(new Tower(Board, Color.White), new ChessPosition('e', 1).ToPosition());
            Board.PutPiece(new King(Board, Color.White), new ChessPosition('d', 1).ToPosition());

            Board.PutPiece(new Tower(Board, Color.Black), new ChessPosition('c', 7).ToPosition());
            Board.PutPiece(new Tower(Board, Color.Black), new ChessPosition('c', 8).ToPosition());
            Board.PutPiece(new Tower(Board, Color.Black), new ChessPosition('d', 7).ToPosition());
            Board.PutPiece(new Tower(Board, Color.Black), new ChessPosition('e', 7).ToPosition());
            Board.PutPiece(new Tower(Board, Color.Black), new ChessPosition('e', 8).ToPosition());
            Board.PutPiece(new King(Board, Color.Black), new ChessPosition('d', 8).ToPosition());

        }
    }
}
