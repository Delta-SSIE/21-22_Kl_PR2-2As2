using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WPF_13_Naval_battle
{
    class Player
    {

        private TileState[,] _sea;
        private int _shipCount;
        private int _seaSize;

        public int WreckCount { get; private set; }
        public bool IsAlive { 
            get
            {
                return WreckCount < _shipCount;
            } 
        }

        public Player(int shipCount, int seaSize)
        {
            if (shipCount < 1)
                throw new ArgumentException();

            if (seaSize < 2)
                throw new ArgumentException();

            if (shipCount >= seaSize * seaSize)
                throw new ArgumentException("Too many ships");

            _shipCount = shipCount;
            _seaSize = seaSize;

            CreateSea();
            PlaceShips();
        }
        private void CreateSea()
        {
            _sea = new TileState[_seaSize, _seaSize];
        }
        private void PlaceShips()
        {
            Random rnd = new Random();

            int placed = 0; //counter for already placed ships

            do
            {
                int x = rnd.Next(_seaSize);
                int y = rnd.Next(_seaSize);
                if (_sea[x,y] != TileState.Ship)
                {
                    _sea[x, y] = TileState.Ship;
                    placed++;
                }
            }
            while (placed < _shipCount);
        }
        public Coordinates ChooseTarget(TileState[,] opponentMap)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Looks into map, modifies at place of target - notes down hit/missed
        /// </summary>
        /// <param name="target">Selected place to shoot</param>
        /// <returns>True on hitting a ship, false otherwise</returns>
        public bool HandleShot(Coordinates target)
        {
            TileState targetState = _sea[target.X, target.Y];
            switch (targetState)
            {
                case TileState.Empty:
                    _sea[target.X, target.Y] = TileState.Missed;
                    return false;

                case TileState.Ship:
                    _sea[target.X, target.Y] = TileState.Wreck;
                    WreckCount++;
                    return true;

                default:
                    return false;
            }
        }
        public TileState[,] GetPrivateSea()
        {
            return (TileState[,])_sea.Clone();
        }
        public TileState[,] GetPublicSea()
        {
            TileState[,] publicSea = new TileState[_seaSize, _seaSize];
            for (int x = 0; x < _seaSize; x++)
            {
                for (int y = 0; y < _seaSize; y++)
                {
                    //if (_sea[x, y] == TileState.Ship)
                    //    publicSea[x, y] = TileState.Empty;
                    //else
                    //    publicSea[x, y] = _sea[x, y];

                    publicSea[x, y] = _sea[x, y] == TileState.Ship ? TileState.Empty : _sea[x, y];
                }
            }
            return publicSea;
        }
    }
}
