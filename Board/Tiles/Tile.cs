using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board.Tiles
{
    public abstract class Tile : Panel
    {
        protected enum TileType
        {
            Empty = 1 << 0,
            Wall = 1 << 1,
            Door = 1 << 2
        };

        public int X { get; set; }
        public int Y { get; set; }
		
		public string SaveData { get; set; }

        protected const int TileSize = 20;
    }
}
