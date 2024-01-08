using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventarium.Utils
{
    internal class Popups
    {
        public static int GetInt(string message, string titre, string reponseParDefaut)
        {
            bool success = false;
            int value = -1;
            string reponse = "a";

            while (!success && reponse != "")
            {
                string input = Interaction.InputBox(message, titre, reponseParDefaut);

                reponse = string.Copy(input);

                success = int.TryParse(input, out value);

                if (!success && input != "") MessageBox.Show("Veuillez entrer un nombre valide.", "Entrée incorrecte");
            }

            return value;
        }
    }
}
