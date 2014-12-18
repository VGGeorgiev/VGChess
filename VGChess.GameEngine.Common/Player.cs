using VGChess.GameEngine.Common.Contracts;

namespace VGChess.GameEngine.Common
{
    public class Player : IPlayer
    {
        private PieceColor pieceColor;

        private IPlayerEngine playerEngine;

        public string Name { get; set; }
    }
}
