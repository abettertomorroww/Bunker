using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunker.Data
{
    class SavingToFile
    {
        public SavingToFile(string[][] allPlayers, string pathToFile)
        {
            for(int i = 0; i < allPlayers.Length; i++)
            {
                SaveToFile(allPlayers[i], i + 1, pathToFile);
            }
        }

        private void SaveToFile(string[] Player, int number, string pathToFile)
        {
            using (StreamWriter writer = new StreamWriter(new FileStream($"{pathToFile}/Игрок{number}.txt", FileMode.Create, FileAccess.Write)))
            {
                foreach (string str in Player)
                {
                    writer.WriteLine(str);
                }
                writer.Close();
            }
        }
    }
}
