using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekeman
{
    class LoadPekeman
    {
        private static List<PekemanInfo> listPekeman = new List<PekemanInfo>();
        private static List<PekemanInfo> listCaughtPekeman = new List<PekemanInfo>();

        public static List<PekemanInfo> LoadFromFile()
        {
            string[] lines = (Properties.Resources.pekeman).Split(new string[] { "\r\n" },
                              StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < lines.Length; i++)
            {
                AddPekeman(lines[i]);
            }
            return listPekeman;
        }

        private static void AddPekeman(string line)
        {
            string[] valeurs = line.Split(',');
            object imgFront = Properties.Resources.ResourceManager.GetObject(valeurs[6]);
            object imgBack = Properties.Resources.ResourceManager.GetObject(valeurs[7]);

            listPekeman.Add(new PekemanInfo()
            {
                name = valeurs[0],
                sex = (PekemanInfo.pekemanSex)Enum.Parse(typeof(PekemanInfo.pekemanSex), valeurs[1]),
                type = valeurs[2],
                height = valeurs[3],
                weight = valeurs[4],
                generation = valeurs[5],
                photoFront = (Bitmap)imgFront,
                photoBack = (Bitmap)imgBack,
                catchRate = Int32.Parse(valeurs[8]),
                currentHitpoints = Int32.Parse(valeurs[9]),
                maxHitpoints = Int32.Parse(valeurs[9]),
                defensePower = Int32.Parse(valeurs[10]),
                attackPower = Int32.Parse(valeurs[11]),
                baseDamage = Int32.Parse(valeurs[12]),
                attackName = valeurs[13],
                actif = false
            });
        }

        public static void CaughtPekeman(PekemanInfo caughtPekeman)
        {
            for (int i = 0; i < listCaughtPekeman.Count; i++)
            {
                if (listCaughtPekeman[i] == caughtPekeman)
                {
                    return;
                }
            }
            listCaughtPekeman.Add(caughtPekeman);
        }

        public static PekemanInfo GetPekemanListItem(int posList)
        {
            return listPekeman[posList];
        }

        public static List<PekemanInfo> GetPekemanList()
        {
            return listPekeman;
        }

        public static List<PekemanInfo> GetListCaughtPekeman()
        {
            return listCaughtPekeman;
        }

        public static int GetListPekemanLength()
        {
            return listPekeman.Count;
        }

        public static int GetListCaughtPekemanLength()
        {
            return listCaughtPekeman.Count;
        }

        public static PekemanInfo GetActivePekeman()
        {
            for (int i = 0; i < listPekeman.Count; i++)
            {
                if (listPekeman[i].actif == true)
                {
                    return listPekeman[i];
                }
            }
            return null;
        }

        public static void SetActivePekeman(int posList)
        {
            listPekeman[posList].actif = true;
        }
    }

    public class PekemanInfo
    {
        public enum pekemanSex { M, F, MF }
        public string name { get; set; }
        public pekemanSex sex { get; set; }
        public string type { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string generation { get; set; }
        public Bitmap photoFront { get; set; }
        public Bitmap photoBack { get; set; }
        public int catchRate { get; set; }
        public int maxHitpoints { get; set; }
        public int currentHitpoints { get; set; }
        public int defensePower { get; set; }
        public int attackPower { get; set; }
        public int baseDamage { get; set; }
        public string attackName { get; set; }
        public bool actif { get; set; }
    }
    
}
