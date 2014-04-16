using Board.Tiles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board
{
    public class BoardPanel : Panel
    {
        public List<List<Tile>> BoardTiles { get; set; }

        // Default public constructor 
        public BoardPanel() : base()
        {
            BoardTiles = new List<List<Tile>>();

            InitilizeTiles(16, 16);

            PositionTiles();
        }

        private void InitilizeTiles(int xSize, int ySize)
        {
            for (int y = 0; y < xSize - 1; y++)
            {
                List<Tile> row = new List<Tile>();

                for (int x = 0; x < ySize - 1; x++)
                {
                    row.Add(new EmptyTile(x, y));
                }

                BoardTiles.Add(row);
            }
        }

        public void PositionTiles()
        {
            int x = 0, y = 0;

            foreach (List<Tile> tileRow in BoardTiles)
            {
                foreach (Tile tile in tileRow)
                {
                    tile.Location = new Point(x, y);

                    this.Controls.Add(tile);

                    x += Tile.TileSize + 1;
                }
                y += Tile.TileSize + 1;
            }
        }
    }
}
