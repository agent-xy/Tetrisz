using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Tetrisz
{
    class Tetrisz_Items
    {
        public int[,] Hitbox;
        public Brush Color;

        public Tetrisz_Items(List<int[,]> Mintak)
        {
            Random rnd = new Random();
            Hitbox = new int[4, 4];
            Hitbox = Mintak[rnd.Next(0, Mintak.Count)];

            
        }
    }
}
