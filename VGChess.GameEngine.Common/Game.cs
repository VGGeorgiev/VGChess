namespace VGChess.GameEngine.Common
{
    using System.Collections.Generic;

    using VGChess.GameEngine.Common.Contracts;

    public class Game
    {
        private List<Move> playedMoves;

        private PieceColor turn;

        private IPlayer[] players;

        private Result result;

        private CheckStatus checkStatus;
    }
}
