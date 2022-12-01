using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrisz
{
    class Tetrisz_Cube
    {
        public int[] Mat_Pos;
        public int Value;
        public Cube_Item Texture;

        public Tetrisz_Cube(int v, int i, int j)
        {
            Texture = new Cube_Item() {
                Width = 100,
                Height = 100,
            };
            Mat_Pos = new int[2] { i, j };
            Value = v;
        }
    }
}
