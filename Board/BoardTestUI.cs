using Board.Tiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board
{
    public partial class BoardTestUI : Form
    {
        public BoardTestUI()
        {
            InitializeComponent();
        }

        private void boardPanel1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = this.boardPanel1.CreateGraphics())
            {
                WallTile t = new WallTile(0, 0, true);

                Pen p = new Pen(t.TileColor, 2);

                SolidBrush brush = new SolidBrush(t.TileColor);

                g.FillRectangle(brush, 0, 0, Tile.TILE_SIZE, Tile.TILE_SIZE);
                g.DrawRectangle(p, t.DrawTile);

                p.Dispose();
            }
        }
    }
}
