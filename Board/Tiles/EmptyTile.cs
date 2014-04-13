using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board.Tiles
{
    class EmptyTile : Tile
    {
        private List<string> OnTile { get; set; }

        public EmptyTile (int x, int y)
        {
            X = x;
            Y = y;
            BackColor = Color.Azure;
            Size = new Size(TileSize, TileSize);
        }
    }
}
