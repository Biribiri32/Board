using Board.Tiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board
{
    public partial class BoardUI : Form
    {
        public BoardUI(Tile[,] tiles)
        {
            InitializeComponent();

            AddTiles(tiles);
        }

        public void AddTiles(Tile[,] tiles)
        {
            foreach(Tile tile in tiles)
            {
                GameBoard.Controls.Add(tile);
            }
        }
    }
}
