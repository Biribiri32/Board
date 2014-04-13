using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board.Tiles
{
    public class WallTile : Tile
    {
        public bool EdgeTile { get; set; }

        public WallTile (int x, int y, bool isEdge)
        {
            X = x;
            Y = y;
            EdgeTile = isEdge;
            BackColor = Color.Black;
            Size = new Size(TileSize, TileSize);
        }
    }
}
