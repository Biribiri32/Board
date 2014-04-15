using Board.Tiles;
using System;
using System.Collections.Generic;
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
        }
    }
}
