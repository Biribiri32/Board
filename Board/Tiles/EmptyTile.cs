using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board.Tiles
{
    class EmptyTile : Tile
    {
        private List<string> OnTile { get; set; }

        public EmptyTile (int x, int y)
        {
            X = x;
			
            Y = y;
			
            BackColor = Color.Green;
			
            Size = new Size(TileSize, TileSize);
			
			string objectsOnTile = ":";
			
			foreach(string obj in OnTile)
			{
				objectsOnTile += obj + ":";
			|}
			
			SaveData = "| ET[" + X + "," + Y + "]L<" + objectsOnTile +"> |";
        }
    }
}
