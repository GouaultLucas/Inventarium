using Inventarium.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace Inventarium
{
    public partial class Inventarium : Form
    {
        private DataManager dataManager = new DataManager();
        public Inventarium()
        {
            InitializeComponent();
        }

        private void Inventarium_Shown(object sender, EventArgs e)
        {
            dataManager.PathChecks();

            LoadList();
        }

        private void LoadList()
        {
            LVProduit.Items.Clear();

            List<string> lines = dataManager.LoadLines();
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                string[] valeurs = line.Split(';');

                string reference = valeurs[0],
                    fournisseur = valeurs[1],
                    categorie = valeurs[2],
                    nom = valeurs[3],
                    prixHT = valeurs[4],
                    prixTTC = valeurs[5],
                    date = valeurs[6],
                    quantite = valeurs[7];

                ListViewItem item = new ListViewItem(reference);
                item.SubItems.Add(fournisseur);
                item.SubItems.Add(categorie);
                item.SubItems.Add(nom);
                item.SubItems.Add(prixHT);
                item.SubItems.Add(prixTTC);
                item.SubItems.Add(date);
                item.SubItems.Add(quantite);

                LVProduit.Items.Add(item);
            }
        }

        private void FermetureProduitAjouter(object sender, EventArgs e)
        {
            LoadList();
            this.Show();
        }
        private void BAjouter_Click(object sender, EventArgs e)
        {
            ProduitAjouter fen = new ProduitAjouter();
            fen.FormClosed += FermetureProduitAjouter;
            this.Hide();
            fen.Show();
        }

        private void Inventarium_Load(object sender, EventArgs e)
        {
            ReinitialiserChamps();
        }

        private void ReinitialiserChamps()
        {
            TRef.Text = String.Empty;
            TFournisseur.Text = String.Empty;
            TCateg.Text = String.Empty;
            TNom.Text = String.Empty;

            DTApres.Value = DateTime.Now;
            DTAvant.Value = DateTime.Now;

            DTApres.Checked = false;
            DTAvant.Checked = false;
        }
        private void BVider_Click(object sender, EventArgs e)
        {
            ReinitialiserChamps();
        }
        private void Rechercher(object sender, EventArgs e)
        {

        }
    }
}
