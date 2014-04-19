using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board.Tiles
{
    [Serializable]
    public class EmptyTile : Tile
    {
        private List<string> OnTile { get; set; }

        public EmptyTile (int x, int y)
        {
            X = x;
			
            Y = y;

            DrawTile = new Rectangle(x, y, TileSize, TileSize);

            SolidBrush blueBrush = new SolidBrush(Color.Blue);

            OnTile = new List<string>();

            OnTile.Add("N/A");
			
			string objectsOnTile = ":";
			
			foreach(string obj in OnTile)
			{
				objectsOnTile += obj + ":";
			}
			
			SaveData = "| ET[" + X + "," + Y + "]L<" + objectsOnTile +"> |";
        }
    }
}
