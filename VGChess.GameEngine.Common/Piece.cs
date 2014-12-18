namespace VGChess.GameEngine.Common
{
    public abstract class Piece
    {
        public PieceType Type { get; set; }

        public PieceColor Color { get; set; }

        public Square PlaceAt { get; set; }

        public bool Moved { get; set; }

        public abstract Square[] ValidMoves();

        public abstract Square[] AttackSquares();

        public abstract Square[] CaptureFreeMoves();

        public abstract bool ToBeCaptured();
    }
}
