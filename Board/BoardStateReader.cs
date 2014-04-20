using Board.Tiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Board
{
    public class BoardStateReader
    {
        private const string TILE_SIZE_PATTERN = @"\[([^]]*)\]";

        public BoardStateReader()
        {
            GenerateTileFromText("|WT[0,0]BTrue|");
        }

        private void GenerateTileFromText(string textToRead)
        {
            Tile tileToCreate;

            // |CC[
            string TileType = textToRead.Substring(1, 2);

            var matches = Regex.Matches(textToRead, TILE_SIZE_PATTERN);

            string[] values;

            // [#,#]
            foreach (Match m in matches)
            {
                values = m.Groups[1].Value.Split(',');
            }
            //int x = Convert.ToInt32(values[0]);

            CreateTile(tileToCreate, TileType, );
        }

        private void CreateTile(ref Tile tile, string tileType, int x, int y, bool? stateBool)
        {
            if (tileType == "WT")
                tile = new WallTile(x, y, (bool)stateBool);
        }
    }
}
