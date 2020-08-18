using ChessGame.board;
using System.ComponentModel.Design;

namespace ChessGame.chess
{
    class Tower : Piece
    {
        public Tower(Board board, Color color) : base(color, board) { }

        public override string ToString()
        {
            return "T";
        }

        private bool CanMove(Position position)
        {
            Piece p = Board.piece(position);
            return p == null || p.Color != Color;
        }

        public override bool[,] PossibleMovements()
        {
            bool[,] mat = new bool[Board.Lines, Board.Columns];

            Position position = new Position(0, 0);

            // upper
            position.DefineValues(position.Line - 1, position.Column);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
                if (Board.piece(position) != null && Board.piece(position).Color != Color)
                {
                    break;
                }
                position.Line = position.Line - 1;
            }

            // down
            position.DefineValues(position.Line - 1, position.Column);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
                if (Board.piece(position) != null && Board.piece(position).Color != Color)
                {
                    break;
                }
                position.Line = position.Line + 1;
            }

            // right
            position.DefineValues(position.Line, position.Column + 1);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
                if (Board.piece(position) != null && Board.piece(position).Color != Color)
                {
                    break;
                }
                position.Column = position.Column + 1;
            }

            // left
            position.DefineValues(position.Line, position.Column - 1);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
                if (Board.piece(position) != null && Board.piece(position).Color != Color)
                {
                    break;
                }
                position.Column = position.Column - 1;
            }

            return mat;
        }
    }
}
