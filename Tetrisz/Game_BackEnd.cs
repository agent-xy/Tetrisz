using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrisz
{
    class Game_BackEnd
    {
        public static List<Tetrisz_Items> _Elemek;
        public static Tetrisz_Cube[,] _Map;

        private static List<int[,]> _Mintak;
        public static void Start_Game()
        {
            _Mintak_Upload();
            _Map_Gen();
        }

        private static void _Mintak_Upload()
        {
            _Mintak = new List<int[,]>();
            _Mintak.Add(new int[,] {
                {1, 0, 0, 0 },
                {1, 0, 0, 0 },
                {1, 0, 0, 0 },
                {1, 0, 0, 0 },
            });
        }

        private static void _Map_Gen()
        {
            _Map = new Tetrisz_Cube[10, 20];
            for (int i = 0; i < _Map.GetLength(0); i++)
            {
                for (int j = 0; j < _Map.GetLength(1); j++)
                {
                    _Map[i, j] = new Tetrisz_Cube(0, i, j);
                    MainWindow._Main._WP_Grid.Children.Add(_Map[i, j].Texture);
                }
            }
        }
    }
}
