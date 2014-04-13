using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board.Tiles
{
    class DoorTile : Tile
    {
        public bool DoorOpen { get; set; }

        public DoorTile (int x, int y, bool isOpen)
        {
            X = x;
            Y = y;
            DoorOpen = isOpen;
            BackColor = Color.Brown;
            Size = new Size(TileSize, TileSize);
        }
    }
}
