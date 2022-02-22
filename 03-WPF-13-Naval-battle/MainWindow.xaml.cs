using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _03_WPF_13_Naval_battle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int _shipCount = 5;
        private const int _seaSize = 3;
        private const int _shotWait = 750; //milliseconds delay

        private Player _player;
        private Player _computer;
        private DispatcherTimer _shotTimer;

        private bool _canShoot;

        public MainWindow()
        {
            InitializeComponent();
            _shotTimer = new DispatcherTimer();
            _shotTimer.Interval = TimeSpan.FromMilliseconds(_shotWait);
            _shotTimer.Tick += _shotTimer_Tick;

            //vytvořit oba hráče
            _player = new Player(_shipCount, _seaSize);
            _computer = new Player(_shipCount, _seaSize);
            _canShoot = true;

            // vytvořit oba displeje
            InitializeDisplay(PlayerSeaDisplay, _player.GetPrivateSea());
            InitializeDisplay(ComputerSeaDisplay, _computer.GetPublicSea(), true);

            // inicializovat skore
            RenderShipsDisplay(PlayerShipsDisplay, _player.WreckCount);
            RenderShipsDisplay(ComputerShipsDisplay, _computer.WreckCount);

        }

        private void InitializeDisplay(Grid display, TileState[,] sea, bool isClickable = false)
        {
            for (int i = 0; i < _seaSize; i++)
            {
                display.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < _seaSize; i++)
            {
                display.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int x = 0; x < _seaSize; x++)
            {
                for (int y = 0; y < _seaSize; y++)
                {
                    Rectangle tile = new Rectangle();
                    RenderTile(tile, sea[x, y]);

                    display.Children.Add(tile);
                    Grid.SetRow(tile, y);
                    Grid.SetColumn(tile, x);

                    if (isClickable)
                    {
                        tile.MouseDown += Tile_MouseDown;
                        tile.Cursor = Cursors.Hand;
                    }
                }
            }

        }

        private void Tile_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!_canShoot) //kliká, ale není na tahu
                return;

            //když hráč klikne
            Rectangle targetTile = (Rectangle)sender;

            int x = Grid.GetColumn(targetTile);
            int y = Grid.GetRow(targetTile);
            Coordinates target = new Coordinates() { X = x, Y = y };

            // vyhodnoť zásah
            bool hit = _computer.HandleShot(target);

            //překreslit
            RenderTile(targetTile, _computer.GetPublicSea()[x, y]);
            RenderShipsDisplay(ComputerShipsDisplay, _computer.WreckCount);

            // když počítač už nemá lodi
            if (!_computer.IsAlive)
            {
                //ohlas vítězství a skonči
                MessageBox.Show("Victory", "You Win!");
                Close();
            }

            if (!hit)
            { 
                _shotTimer.Start();
                _canShoot = false;
            }
        }

        private void RenderTile(Rectangle tile, TileState state)
        {
            switch (state)
            {
                case TileState.Empty:
                    tile.Style = FindResource("EmptyTile") as Style;
                    break;
                case TileState.Ship:
                    tile.Style = FindResource("ShipTile") as Style;
                    break;
                case TileState.Wreck:
                    tile.Style = FindResource("WreckTile") as Style;
                    break;
                case TileState.Missed:
                    tile.Style = FindResource("MissedTile") as Style;
                    break;
                default:
                    break;
            }
        }

        private void RenderShipsDisplay(Label display, int wrecks)
        {
            display.Content = $"{wrecks} / {_shipCount}";
        }
        private void _shotTimer_Tick(object sender, EventArgs e)
        {
            _shotTimer.Stop();
            ComputerMove();
        }
        private void ComputerMove()
        {

            // počítač vymyslí, kam střílet
            Coordinates target = _computer.ChooseTarget(_player.GetPublicSea());

            // vyhodnoť zásah
            bool hit = _player.HandleShot(target);

            // překresli políčko se zásahem
            Rectangle targetTile = FindTileByCoordinates(PlayerSeaDisplay, target);
            RenderTile(targetTile, _player.GetPublicSea()[target.X, target.Y]);
            RenderShipsDisplay(ComputerShipsDisplay, _computer.WreckCount);

            // když hráč už nemá lodi
            if (!_player.IsAlive)
            {
                //ohlas prohru a skonči
                MessageBox.Show("Defeat", "You Lose!");
                Close();
            }

            // pokud se PC trefil, bude střílet zase 
            if (hit)
            { 
                _shotTimer.Start();
            }
            else
            {
                _canShoot = true; //netrefa - dovol hrát hráči
            }

        }

        private Rectangle FindTileByCoordinates(Grid grid, Coordinates coordinates)
        {
            //projdi všechny elementy v gridu
            foreach (var child in grid.Children) 
            {
                Rectangle tile = (Rectangle)child; //můžu, v gridu není nic než rectangle, sám jsem si je tam dal

                //zeptej se na souřadnice
                int x = Grid.GetColumn(tile);
                int y = Grid.GetRow(tile);
                
                //když odpovídají, vrať
                if (x == coordinates.X && y == coordinates.Y)
                    return tile;
            }

            return null;
        }
    }
}
