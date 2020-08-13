using System.Drawing;

namespace ChessGame.board
{
    class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }

        private Piece[,] pieces;

        public Board(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            pieces = new Piece[Lines, Columns];
        }

        public Piece piece(int line, int column)
        {
            return pieces[line, column];
        }
        public Piece piece(Position position)
        {
            return pieces[position.Line, position.Column];
        }

        public bool PieceExist(Position position)
        {
            ValidatePosition(position);
            return piece(position) != null;
        }
        public void PutPiece(Piece piece, Position position)
        {
            if (PieceExist(position))
            {
                throw new BoardException("Already exists an piece in this position!");
            }
            pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }

        public bool ValidPosition(Position position)
        {
            if (position.Line < 0 || position.Line >= Lines || position.Column < 0 || position.Column >= Columns)
            {
                return false;
            }
            return true;
        }
        public void ValidatePosition(Position position)
        {
            if (!ValidPosition(position))
            {
                throw new BoardException("Invalid Position!");
            }
        }
    }
}
