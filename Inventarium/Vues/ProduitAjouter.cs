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
            TRef.Text = string.Empty;
            TFournisseur.Text = string.Empty;
            TCategorie.Text = string.Empty;
            TNom.Text = string.Empty;

            NPrixHT.Value = 0;
            NPrixTTC.Value = 0;

            DTDate.Value = DateTime.Now;

            NQuantite.Value = 0;
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
            string reference = TRef.Text,
                fournisseur = TFournisseur.Text,
                categorie = TCategorie.Text,
                nom = TNom.Text;

            decimal prixHT = NPrixHT.Value,
                prixTTC = NPrixTTC.Value;

            DateTime date = DTDate.Value;

            int quantite = (int) NQuantite.Value;

            Produit produit = new Produit(reference, fournisseur, categorie, nom, prixHT, prixTTC, date, quantite);

            DataManager dataManager = new DataManager();
            dataManager.AjouterProduit(produit);

            this.Close();
        }
    }
}
