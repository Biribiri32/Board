using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board.Tiles
{
    public class WallTile : Tile
    {
        public bool EdgeTile { get; set; }

        public WallTile (int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
