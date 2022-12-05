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
        private static System.Timers.Timer Loader_Timer;
        private static bool Can_Spown;
        private static int[,] Moving_Item;
        public static void Start_Game()
        {
            _Loader_Gen();
            _Mintak_Upload();
            _Pocket_Matrix();
            _Map_Gen();
            Game_On = true;
            Can_Spown = true;
        }

        private static void _Loader_Gen()
        {
            Loader_Timer = new System.Timers.Timer(500);
            Loader_Timer.AutoReset = true;
            Loader_Timer.Elapsed += Loader_Timer_Elapsed;
            Loader_Timer.Start();
        }

        private static void Loader_Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (Game_On)
            {
                if (Can_Spown)
                {
                    Can_Spown = false;
                    _Generate_New_Item();
                } else
                {
                    _Moving_Items_Moving();
                }
                
            }
        }

        private static void _Moving_Items_Moving()
        {

        }

        private static void _Generate_New_Item()
        {
            Random rnd = new Random();
            Moving_Item = _Mintak[rnd.Next(0, _Mintak.Count - 1)];
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
