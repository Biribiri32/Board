using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board.Tiles
{
    class DoorTile : Tile
    {
        public bool DoorOpen { get; set; }

        public DoorTile (int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
