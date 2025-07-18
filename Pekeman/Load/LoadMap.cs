using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Pekeman
{
    class LoadMap
    {
        public static string trainerName { get; set; }
        /// <summary>
        /// Ouvre un tableau
        /// </summary>
        /// <param name="path"></param>
        public static int[,] LoadTiles()
        {
            int[,] tiles = new int[16, 32];
            string[] lines = (Properties.Resources.map).Split(new string[] { "\r\n" }, 
                              StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                string[] valeurs = lines[i].Split(',');
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    tiles[i, j] = Convert.ToInt32(valeurs[j]);
                }
            }
            return tiles;
        }

        public static int[,] LoadCollision(int[,] tiles)
        {
            int[,] tileType = new int[16, 32];

            for (int i = 0; i < tileType.GetLength(0); i++)
            {
                for (int j = 0; j < tileType.GetLength(1); j++)
                {
                    if (Enum.IsDefined(typeof(TilesetImageGenerator.eventTile), tiles[i, j]))
                    {
                        switch (tiles[i, j])
                        {
                            case (int)TilesetImageGenerator.eventTile.herb:
                                tileType[i, j] = 2;
                                break;
                            case (int)TilesetImageGenerator.eventTile.gym:
                                tileType[i, j] = 3;
                                break;
                            case (int)TilesetImageGenerator.eventTile.poke:
                                tileType[i, j] = 4;
                                break;
                        }
                    }
                    else if (Enum.IsDefined(typeof(TilesetImageGenerator.walkableTile), tiles[i, j]))
                    {
                        tileType[i, j] = 1;
                    }
                    else
                    {
                        tileType[i, j] = 0;
                    }
                }
            }
            return tileType;
        }

        /// <summary>
        /// Sauve un tableau
        /// </summary>
        /// <param name="path"></param>
        public static void SaveGame(string path, int[,] tiles)
        {
            string tableauCSV = "";
            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                if (i > 0)
                {
                    tableauCSV += "\n";
                }
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    tableauCSV += tiles[i, j];
                    if (j < 15)
                    {
                        tableauCSV += ",";
                    }
                }
            }
            using (FileStream fs = File.Create(path))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(tableauCSV);
                fs.Write(info, 0, info.Length);
            }
        }
    }
}
