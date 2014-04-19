using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board.Tiles
{
    [Serializable]
    public class WallTile : Tile
    {
        public bool EdgeTile { get; set; }

        public WallTile (int x, int y, bool isEdge)
        {
            X = x;
            Y = y;

            DrawTile = new Rectangle(x, y, TILE_SIZE, TILE_SIZE);

            EdgeTile = isEdge;
			
			SaveData = "| WT[" + X + "," + Y + "]B" + EdgeTile.ToString() + " |";

            TileColor = Color.DarkOrange;
        }
    }
}
