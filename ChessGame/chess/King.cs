using ChessGame.board;

namespace ChessGame.chess
{
    class King : Piece
    {
        public King(Board board, Color color) : base(color, board) { }

        public override string ToString()
        {
            return "K";
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
            if (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }

            // north
            position.DefineValues(position.Line - 1, position.Column + 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }

            // right
            position.DefineValues(position.Line, position.Column + 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }

            // south
            position.DefineValues(position.Line + 1, position.Column + 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }

            // down
            position.DefineValues(position.Line + 1, position.Column);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }

            // so
            position.DefineValues(position.Line + 1, position.Column - 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }

            // left
            position.DefineValues(position.Line, position.Column - 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }

            // no
            position.DefineValues(position.Line - 1, position.Column - 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                mat[position.Line, position.Column] = true;
            }

            return mat;
        }
    }
}
