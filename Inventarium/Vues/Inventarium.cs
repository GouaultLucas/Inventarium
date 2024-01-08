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
using Microsoft.VisualBasic;
using static System.Windows.Forms.ListViewItem;

namespace Inventarium
{
    public partial class Inventarium : Form
    {
        private readonly List<Produit> produits = new List<Produit>();
        public Inventarium()
        {
            InitializeComponent();
        }

        private void Inventarium_Shown(object sender, EventArgs e)
        {
            DataManager.PathChecks();

            LoadList();
        }

        private void LoadList()
        {
            LVProduit.Items.Clear();
            produits.Clear();

            List<string> lines = DataManager.LoadLines();
            foreach (string line in lines)
            {
                Produit produit = DataManager.LineToProduit(line);
                produits.Add(produit);

                ListViewItem item = new ListViewItem(produit.Reference);
                item.SubItems.Add(produit.Fournisseur);
                item.SubItems.Add(produit.Categorie);
                item.SubItems.Add(produit.Nom);
                item.SubItems.Add(produit.PrixHT.ToString());
                item.SubItems.Add(produit.PrixTTC.ToString());
                item.SubItems.Add(line.Split(';')[6]);
                item.SubItems.Add(produit.Quantite.ToString());

                LVProduit.Items.Add(item);
            }
        }

        private void LoadList(List<Produit> produits)
        {
            LVProduit.Items.Clear();

            foreach (Produit produit in produits)
            {
                LVProduit.Items.Add(DataManager.LineToItem(DataManager.ProduitToLine(produit)));
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

            DTApres.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            DTAvant.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            DTApres.Checked = false;
            DTAvant.Checked = false;
        }
        private void BVider_Click(object sender, EventArgs e)
        {
            ReinitialiserChamps();
        }
        private void Rechercher(object sender, EventArgs e)
        {
            LVProduit.Items.Clear();

            List<Produit> lesProduits = produits.ToList();

            if(TRef.Text != "")
            {
                for (int i = 0; i < lesProduits.Count; i++)
                {
                    if (!lesProduits[i].Reference.Contains(TRef.Text))
                    {
                        lesProduits.RemoveAt(i);
                        i--;
                    }
                }
            }

            if(TFournisseur.Text != "")
            {
                for (int i = 0; i < lesProduits.Count; i++)
                {
                    if (!lesProduits[i].Fournisseur.Contains(TFournisseur.Text))
                    {
                        lesProduits.RemoveAt(i);
                        i--;
                    }
                }
            }

            if (TCateg.Text != "")
            {
                for (int i = 0; i < lesProduits.Count; i++)
                {
                    if (!lesProduits[i].Categorie.Contains(TCateg.Text))
                    {
                        lesProduits.RemoveAt(i);
                        i--;
                    }
                }
            }

            if (TNom.Text != "")
            {
                for (int i = 0; i < lesProduits.Count; i++)
                {
                    if (!lesProduits[i].Nom.Contains(TNom.Text))
                    {
                        lesProduits.RemoveAt(i);
                        i--;
                    }
                }
            }

            if(DTApres.Checked && DTAvant.Checked)
            {
                if (DTApres.Value > DTAvant.Value)
                {
                    (DTAvant.Value, DTApres.Value) = (DTApres.Value, DTAvant.Value);
                }
            }

            if(DTApres.Checked)
            {
                for (int i = 0; i < lesProduits.Count; i++)
                {
                    if (lesProduits[i].Date < DTApres.Value)
                    {
                        lesProduits.RemoveAt(i);
                        i--;
                    }
                }
            }

            if (DTAvant.Checked)
            {
                for (int i = 0; i < lesProduits.Count; i++)
                {
                    if (lesProduits[i].Date > DTAvant.Value)
                    {
                        lesProduits.RemoveAt(i);
                        i--;
                    }
                }
            }

            LoadList(lesProduits);
        }

        private void SupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LVProduit_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                MenuContextuel.Show(LVProduit, e.X, e.Y);
            }
        }

        private void MenuContextuel_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Text == "Ajouter")
            {
                int value = Popups.GetInt("Combien voulez-vous enlever ?", "Veuillez entrer un nombre", "0");

                for (int i = 0; i < LVProduit.SelectedItems.Count; i++)
                {
                    Produit ancienProduit = DataManager.LineToProduit(DataManager.ItemToLine(LVProduit.SelectedItems[i]));
                    Produit nouveauProduit = ancienProduit.Clone();
                    nouveauProduit.Quantite += value;

                    DataManager.ModifierProduit(ancienProduit, nouveauProduit);

                    LoadList();
                }
            }
            else if(e.ClickedItem.Text == "Enlever")
            {
                int value = Popups.GetInt("Combien voulez-vous enlever ?", "Veuillez entrer un nombre", "0");

                for (int i = 0; i < LVProduit.SelectedItems.Count; i++)
                {
                    Produit ancienProduit = DataManager.LineToProduit(DataManager.ItemToLine(LVProduit.SelectedItems[i]));
                    Produit nouveauProduit = ancienProduit.Clone();
                    nouveauProduit.Quantite -= value;

                    DataManager.ModifierProduit(ancienProduit, nouveauProduit);

                    LoadList();
                }
            }
        }
    }
}
