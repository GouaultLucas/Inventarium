using Inventarium.Utils;
using System;
using System.Windows.Forms;

namespace Inventarium
{
    public partial class ProduitAjouter : Form
    {
        public ProduitAjouter()
        {
            InitializeComponent();
            ReinitialiserChamps();
        }

        private void ReinitialiserChamps()
        {
            ChampRef.Text = string.Empty;
            ChampFournisseur.Text = string.Empty;
            ChampCategorie.Text = string.Empty;
            ChampNom.Text = string.Empty;

            ChampPrixHT.Value = 0;
            ChampPrixTTC.Value = 0;

            ChampDate.Value = DateTime.Now;

            ChampQuantite.Value = 0;
        }

        private void BVider_Click(object sender, EventArgs e)
        {
            ReinitialiserChamps();
        }

        private void ProduitAjouter_Load(object sender, EventArgs e)
        {

        }

        private void BAjouter_Click(object sender, EventArgs e)
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

                int quantite = (int)ChampQuantite.Value;

                Produit produit = new Produit(reference, fournisseur, categorie, nom, prixHT, prixTTC, date, quantite);

                DataManager.AjouterProduit(produit);

                this.Close();
            }
        }

        private void numericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
            {
                e.KeyChar = ((System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        private void ProduitAjouter_KeyDown(object sender, KeyEventArgs e)
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
                    BAjouter_Click(sender, e);
                }
            }
        }
    }
}
