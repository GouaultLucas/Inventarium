using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventarium.Vues
{
    public partial class ProduitModifier : Form
    {
        public Produit produit;
        public ProduitModifier(Produit leProduit)
        {
            InitializeComponent();
            this.produit = leProduit;

            ReinitialiserChamps();
        }

        private void ProduitModifier_Load(object sender, EventArgs e)
        {

        }

        private void BReset_Click(object sender, EventArgs e)
        {
            ReinitialiserChamps();
        }

        private void ReinitialiserChamps()
        {
            ChampRef.Text = produit.Reference;
            ChampFournisseur.Text = produit.Fournisseur;
            ChampCategorie.Text = produit.Categorie;
            ChampNom.Text = produit.Nom;

            ChampPrixHT.Value = produit.PrixHT;
            ChampPrixTTC.Value = produit.PrixTTC;

            ChampDate.Value = produit.Date;

            ChampQuantite.Value = produit.Quantite;
        }

        private void BModifier_Click(object sender, EventArgs e)
        {
            if (ChampRef.Text == string.Empty)
            {
                MessageBox.Show("Le champ réservé à la référence du produit est vide !", "Attention !");
            }
            else if (ChampFournisseur.Text == string.Empty)
            {
                MessageBox.Show("Le champ réservé au fournisseur du produit est vide !", "Attention !");
            }
            else if (ChampCategorie.Text == string.Empty)
            {
                MessageBox.Show("Le champ réservé à la catégorie du produit est vide !", "Attention !");
            }
            else if (ChampNom.Text == string.Empty)
            {
                MessageBox.Show("Le champ réservé au nom du produit est vide !", "Attention !");
            }
            else
            {
                string reference = ChampRef.Text,
                fournisseur = ChampFournisseur.Text,
                categorie = ChampCategorie.Text,
                nom = ChampNom.Text;

                decimal prixHT = ChampPrixHT.Value,
                    prixTTC = ChampPrixTTC.Value;

                DateTime date = ChampDate.Value;

                int quantite = (int) ChampQuantite.Value;

                this.produit = new Produit(reference, fournisseur, categorie, nom, prixHT, prixTTC, date, quantite);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void ProduitModifier_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void numericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
            {
                e.KeyChar = ((System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        private void ProduitModifier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (ActiveControl.TabIndex < 7)
                {
                    for (int i = 0; i < Controls.Count; i++)
                    {
                        if (Controls[i].TabStop == true && Controls[i].TabIndex == ActiveControl.TabIndex + 1)
                        {
                            ActiveControl = Controls[i];
                        }
                    }
                }
                else if (ActiveControl.TabIndex == 7)
                {
                    BModifier_Click(sender, e);
                }
            }
        }
    }
}
