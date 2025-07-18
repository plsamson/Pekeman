using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekeman
{
    class TilesetImageGenerator
    {
        // Différentes tailles concernant les images dans le fichier de tuiles de jeu
        public const int IMAGE_WIDTH = 32, IMAGE_HEIGHT = 32;
        private const int TILE_LEFT = 20, TILE_TOP = 20;
        private const int SEPARATEUR_TILE = 2;

        public static List<int> listeCollision = new List<int>();
        private static List<TileCoord> listeCoord = new List<TileCoord>();
        private static List<Bitmap> listeBitmap = new List<Bitmap>();

        public enum walkableTile { grass = 0, plant_1 = 2, plant_2 = 3, plant_3 = 4,
            plant_4 = 5, plant_5 = 6, flower_g = 7, flower_d = 8, dock = 58, road = 57};
        public enum eventTile { herb = 1, gym = 63, poke = 64 };

        /// <summary>
        /// Constructeur statique
        /// </summary>
        static TilesetImageGenerator()
        {
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 5 }); // GRASS = 0
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 6 }); // HERB = 1
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 4 }); // PLANT1 = 2
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 5 }); // PLANT2 = 3
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 6 }); // PLANT3 = 4
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 7 }); // PLANT4 = 5
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 8 }); // PLANT5 = 6
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 1 }); // FLOWER_G = 7
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 2 }); // FLOWER_D = 8
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 2 }); // DOOR = 9
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 4 }); // POKE_LOGO = 10
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 0 }); // MART_WALL_G = 11
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 3 }); // MART_WALL_D = 12
            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 0 }); // MART_WINDOW_G = 13
            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 3 }); // MART_WINDOW_D = 14
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 1 }); // MART_ROOF_G = 15
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 2 }); // MART_ROOF_C = 16
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 3 }); // MART_ROOF_D = 17
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 0 }); // MART_BOTTOM_G = 18
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 1 }); // MART_BOTTOM_C = 19
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 3 }); // MART_BOTTOM_D = 20
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 5 }); // GYM_LOGO = 21
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 5 }); // GYM_WINDOW_WALL = 22
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 4 }); // GYM_WINDOW_G = 23
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 7 }); // GYM_WINDOW_D = 24
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 7 }); // GYM_ROOF_TOP = 25
            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 7 }); // GYM_ROOF_BOTTOM = 26
            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 4 }); // GYM_BOTTOM_G = 27
            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 5 }); // GYM_BOTTOM_C = 28
            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 6 }); // GYM_BOTTOM_D= 29
            listeCoord.Add(new TileCoord() { Ligne = 8, Colonne = 0 }); // HOUSE1 = 30
            listeCoord.Add(new TileCoord() { Ligne = 8, Colonne = 1 }); // HOUSE2 = 31
            listeCoord.Add(new TileCoord() { Ligne = 8, Colonne = 2 }); // HOUSE3 = 32
            listeCoord.Add(new TileCoord() { Ligne = 9, Colonne = 0 }); // HOUSE4 = 33
            listeCoord.Add(new TileCoord() { Ligne = 9, Colonne = 1 }); // HOUSE5 = 34
            listeCoord.Add(new TileCoord() { Ligne = 9, Colonne = 2 }); // HOUSE6 = 35
            listeCoord.Add(new TileCoord() { Ligne = 10, Colonne = 0 }); // HOUSE7 = 36
            listeCoord.Add(new TileCoord() { Ligne = 10, Colonne = 1 }); // HOUSE8 = 37
            listeCoord.Add(new TileCoord() { Ligne = 10, Colonne = 2 }); // HOUSE9 = 38
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 10 }); // WATER_C = 39
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 9 }); // WATER_TOP_G = 40
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 10 }); // WATER_TOP_C = 41
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 11 }); // WATER_TOP_D = 42
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 9 }); // WATER_G = 43
            listeCoord.Add(new TileCoord() { Ligne = 2, Colonne = 0 }); // CLIFF_G = 44
            listeCoord.Add(new TileCoord() { Ligne = 2, Colonne = 2 }); // CLIFF_D = 45
            listeCoord.Add(new TileCoord() { Ligne = 3, Colonne = 0 }); // CLIFF_BOTTOM_G = 46
            listeCoord.Add(new TileCoord() { Ligne = 3, Colonne = 1 }); // CLIFF_BOTTOM_C = 47
            listeCoord.Add(new TileCoord() { Ligne = 3, Colonne = 2 }); // CLIFF_BOTTOM_D = 48
            listeCoord.Add(new TileCoord() { Ligne = 1, Colonne = 12 }); // WATER_CORNER_G = 49
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 12 }); // WATER_CORNER_D = 50
            listeCoord.Add(new TileCoord() { Ligne = 2, Colonne = 12 }); // ROOF_RED = 51
            listeCoord.Add(new TileCoord() { Ligne = 3, Colonne = 12 }); // ROOF_BLUE_G = 52
            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 12 }); // ROOF_BLUE_D = 53
            listeCoord.Add(new TileCoord() { Ligne = 8, Colonne = 3 }); // HOUSE_BOTTOM_G = 54
            listeCoord.Add(new TileCoord() { Ligne = 9, Colonne = 3 }); // HOUSE_BOTTOM_D = 55
            listeCoord.Add(new TileCoord() { Ligne = 10, Colonne = 3 }); // HOUSE_BOTTOM_WINDOW = 56
            listeCoord.Add(new TileCoord() { Ligne = 0, Colonne = 0 }); // ROAD = 57
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 7 }); // DOCK = 58
            listeCoord.Add(new TileCoord() { Ligne = 10, Colonne = 4 }); // BRICK_BOTTOM_G = 59
            listeCoord.Add(new TileCoord() { Ligne = 9, Colonne = 5 }); // BRICK BOTTOM_C = 60
            listeCoord.Add(new TileCoord() { Ligne = 10, Colonne = 6 }); // BRICK BOTTOM_D = 61
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 2 }); // MART_WALL = 62
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 2 }); // DOOR_GYM = 63
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 2 }); // DOOR_POKE = 64
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 12 }); // ROOF_MIDDLE_BLUE = 65

            for (int i = 0; i < listeCoord.Count; i++)
            {
                listeBitmap.Add(LoadTile(i));
            }
            
        }
        
        private static Bitmap LoadTile(int posListe)
        {
            Image source = Pekeman.Properties.Resources.Tileset;
            TileCoord coord = listeCoord[posListe];
            Rectangle crop = new Rectangle(TILE_LEFT + (coord.Colonne * (IMAGE_WIDTH + SEPARATEUR_TILE)), TILE_TOP + coord.Ligne * (IMAGE_HEIGHT + SEPARATEUR_TILE), IMAGE_WIDTH, IMAGE_HEIGHT);

            var bmp = new Bitmap(crop.Width, crop.Height);
            using (var gr = Graphics.FromImage(bmp))
            {
                gr.DrawImage(source, new Rectangle(0, 0, bmp.Width, bmp.Height), crop, GraphicsUnit.Pixel);
            }
            return bmp;
        }

        public static Bitmap GetTile(int posListe)
        {
            return listeBitmap[posListe];
        }

    }

    public class TileCoord
    {
        public int Ligne { get; set; }
        public int Colonne { get; set; }
    };
}