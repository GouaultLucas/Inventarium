﻿using Inventarium.Utils;
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
using Inventarium.Vues;

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

            string[] ordreTri = TriDataManager.Load().Split(';');

            for(int i = 0; i < ordreTri.Count(); i++)
            {
                if (ordreTri[i] != "")
                {
                    if (ordreTri[i] == "Fournisseur")
                    {
                        lines = lines.OrderBy(x => x.Split(';')[1]).ToList();
                    }
                    else if(ordreTri[i] == "Catégorie")
                    {
                        lines = lines.OrderBy(x => x.Split(';')[2]).ToList();
                    }
                    else if(ordreTri[i] == "Nom")
                    {
                        lines = lines.OrderBy(x => x.Split(';')[3]).ToList();
                    }
                    else if (ordreTri[i] == "Date")
                    {
                        lines.Sort((a,b) =>
                        {
                            string[] aDateStr = a.Split(';')[6].Split('/');
                            string[] bDateStr = b.Split(';')[6].Split('/');

                            DateTime aDate = new DateTime(int.Parse(aDateStr[2]), int.Parse(aDateStr[1]), int.Parse(aDateStr[0]));
                            DateTime bDate = new DateTime(int.Parse(bDateStr[2]), int.Parse(bDateStr[1]), int.Parse(bDateStr[0]));

                            return aDate.CompareTo(bDate);
                        });
                    }
                }
            }

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
            ChampRef.Text = String.Empty;
            ChampFournisseur.Text = String.Empty;
            ChampCateg.Text = String.Empty;
            ChampNom.Text = String.Empty;

            ChampApres.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            ChampAvant.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            ChampApres.Checked = false;
            ChampAvant.Checked = false;
        }
        private void BVider_Click(object sender, EventArgs e)
        {
            ReinitialiserChamps();
        }
        private void Rechercher(object sender, EventArgs e)
        {
            LVProduit.Items.Clear();

            List<Produit> lesProduits = produits.ToList();

            if(ChampRef.Text != "")
            {
                for (int i = 0; i < lesProduits.Count; i++)
                {
                    if (!lesProduits[i].Reference.Contains(ChampRef.Text))
                    {
                        lesProduits.RemoveAt(i);
                        i--;
                    }
                }
            }

            if(ChampFournisseur.Text != "")
            {
                for (int i = 0; i < lesProduits.Count; i++)
                {
                    if (!lesProduits[i].Fournisseur.Contains(ChampFournisseur.Text))
                    {
                        lesProduits.RemoveAt(i);
                        i--;
                    }
                }
            }

            if (ChampCateg.Text != "")
            {
                for (int i = 0; i < lesProduits.Count; i++)
                {
                    if (!lesProduits[i].Categorie.Contains(ChampCateg.Text))
                    {
                        lesProduits.RemoveAt(i);
                        i--;
                    }
                }
            }

            if (ChampNom.Text != "")
            {
                for (int i = 0; i < lesProduits.Count; i++)
                {
                    if (!lesProduits[i].Nom.Contains(ChampNom.Text))
                    {
                        lesProduits.RemoveAt(i);
                        i--;
                    }
                }
            }

            if(ChampApres.Checked && ChampAvant.Checked)
            {
                if (ChampApres.Value > ChampAvant.Value)
                {
                    (ChampAvant.Value, ChampApres.Value) = (ChampApres.Value, ChampAvant.Value);
                }
            }

            if(ChampApres.Checked)
            {
                for (int i = 0; i < lesProduits.Count; i++)
                {
                    if (lesProduits[i].Date < ChampApres.Value)
                    {
                        lesProduits.RemoveAt(i);
                        i--;
                    }
                }
            }

            if (ChampAvant.Checked)
            {
                for (int i = 0; i < lesProduits.Count; i++)
                {
                    if (lesProduits[i].Date > ChampAvant.Value)
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
            else if(e.ClickedItem.Text == "Modifier")
            {
                if(selectedIndex != -1)
                {
                    Produit leProduit = DataManager.LineToProduit(DataManager.ItemToLine(LVProduit.Items[selectedIndex]));
                    using (ProduitModifier frm = new ProduitModifier(leProduit))
                    {
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();

                        DataManager.ModifierProduit(leProduit, frm.produit);

                        LoadList();
                    }
                }
                else
                {
                    MessageBox.Show("Attention !", "Veuillez d'abord sélectionner une valeur dans le tableau !");
                }
            }
            else if(e.ClickedItem.Text == "Supprimer")
            {
                if(selectedIndex != -1)
                {
                    for(int i = 0; i < LVProduit.SelectedItems.Count; i++)
                    {
                        DataManager.SupprimerProduit(DataManager.LineToProduit(DataManager.ItemToLine(LVProduit.SelectedItems[i])));
                    }

                    LoadList();
                }
                else
                {
                    MessageBox.Show("Attention !", "Veuillez d'abord sélectionner une valeur dans le tableau !");
                }
            }
        }
        private int selectedIndex = -1;

        private void LVProduit_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedIndex = e.ItemIndex;
        }

        private void BOuvrirTri_Click(object sender, EventArgs e)
        {
            ModifierOptionsTri modifierOptionsTri = new ModifierOptionsTri();
            this.Hide();
            modifierOptionsTri.Show();
            modifierOptionsTri.FormClosed += (source, args) => 
            {
                this.Show();
                LoadList();
            };
        }

        private void Inventarium_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (ActiveControl.TabIndex < 5)
                {
                    for (int i = 0; i < Controls.Count; i++)
                    {
                        if (Controls[i].TabStop == true && Controls[i].TabIndex == ActiveControl.TabIndex + 1)
                        {
                            ActiveControl = Controls[i];
                        }
                    }
                }
                else if (ActiveControl.TabIndex == 5)
                {
                    Rechercher(sender, e);
                }
            }
        }
    }
}
