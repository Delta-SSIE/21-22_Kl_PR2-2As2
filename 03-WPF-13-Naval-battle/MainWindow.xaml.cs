﻿using System;
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

namespace _03_WPF_13_Naval_battle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int _shipCount = 5;
        private const int _seaSize = 3;

        private Player _player;
        private Player _computer;

        public MainWindow()
        {
            InitializeComponent();

            //vytvořit oba hráče
            _player = new Player(_shipCount, _seaSize);
            _computer = new Player(_shipCount, _seaSize);

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
            //když hráč klikne
            Rectangle targetTile = (Rectangle)sender;

            int x = Grid.GetColumn(targetTile);
            int y = Grid.GetRow(targetTile);
            Coordinates target = new Coordinates() { X = x, Y = y };

            // vyhodnoť zásah
            _computer.HandleShot(target);

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

            // počítač vymyslí, kma střílet
            // vyhodnoť zásah
            // když hráč už nemá lodi
            //ohlas prohru a skonči
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
    }
}
