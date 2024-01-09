using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventarium.Utils
{
    internal class TriDataManager
    {
        readonly static string csvPath = "Parametres/Options_Tri.csv";
        private static bool DataFileExists()
        {
            return System.IO.File.Exists(csvPath);
        }
        private static bool DataFolderExists()
        {
            return System.IO.Directory.Exists("Parametres");
        }
        public static void PathChecks()
        {
            if (!DataFolderExists())
            {
                System.IO.Directory.CreateDirectory("Parametres");
            }
            if (!DataFileExists())
            {
                System.IO.File.WriteAllText(csvPath, "");
            }
        }

        public static string Load()
        {
            PathChecks();

            string str = System.IO.File.ReadAllText(csvPath);

            return str;
        }

        public static void Save(string str)
        {
            System.IO.File.WriteAllText(csvPath, str, Encoding.UTF8);
        }
    }
}
