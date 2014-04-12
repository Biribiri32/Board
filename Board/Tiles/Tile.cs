using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Board.Tiles
{
    public abstract class Tile
    {
        protected enum TileType
        {
            Empty = 1 << 0,
            Wall = 1 << 1,
            Door = 1 << 2
        };

        public int X { get; set; }
        public int Y { get; set; }
        public Color TileColor { get; set; }
    }
}
