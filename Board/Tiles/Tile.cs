using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board.Tiles
{
    [Serializable]
    public abstract class Tile
    {
        protected enum TileType
        {
            Empty = 1 << 0,
            Wall = 1 << 1,
            Door = 1 << 2
        };

        public const int TILE_SIZE = 20;

        public int X { get; set; }
        public int Y { get; set; }

        public Rectangle DrawTile { get; set; }
		
		public string SaveData { get; set; }

        public Color TileColor { get; set; }
    }
}
