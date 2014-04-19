using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board.Tiles
{
    [Serializable]
    public class DoorTile : Tile
    {
        public bool DoorOpen { get; set; }

        public DoorTile (int x, int y, bool isOpen)
        {
            X = x;
            Y = y;

            DrawTile = new Rectangle(x, y, TileSize, TileSize);

            SolidBrush blueBrush = new SolidBrush(Color.Coral);

            DoorOpen = isOpen;
			
			SaveData = "| DT[" + X + "," + Y + "]B" + DoorOpen.ToString() + " |";
        }
    }
}
