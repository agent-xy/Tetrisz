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
        private static bool Game_On;
        private static Tetrisz_Cube[,] Pocket_Map;
        public static void Start_Game()
        {
            _Mintak_Upload();
            _Pocket_Matrix();
            _Map_Gen();
            Game_On = true;
            _Loader();
        }

        private static void _Pocket_Matrix()
        {
            Pocket_Map = new Tetrisz_Cube[4, 4];

            for (int i = 0; i < Pocket_Map.GetLength(0); i++)
            {
                for (int j = 0; j < Pocket_Map.GetLength(1); j++)
                {
                    Pocket_Map[i, j] = new Tetrisz_Cube(0, i, j);
                    MainWindow._Main._SP_Pocket_Matrix.Children.Add(Pocket_Map[i, j].Texture);
                }
            }
        }

        private static void _Loader()
        {
            while (Game_On)
            {

            }
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
