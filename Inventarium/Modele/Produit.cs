using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventarium
{
    internal class Produit
    {
        private string nom;
        private string reference;
        private string fournisseur;
        private string categorie;

        private decimal prixHT,
                       prixTTC;

        private DateTime  date;

        private int       quantite;
        
        public Produit(bool boobool)
        {
            Reference = "Youn1";
            Fournisseur = "Thomas Corp";
            Categorie = "Esclave Sexuel";
            Nom = "Younette";
            PrixHT = 112;
            PrixTTC = 200;
            Date = DateTime.Now;
            Quantite = 1;
        }
        public Produit()
        {

        }

        public Produit(
            String reference,
            String fournisseur,
            String categorie,
            String nom,
            decimal prixHT,
            decimal prixTTC,
            DateTime date,
            int quantite
        ) {
            Reference = reference;
            Fournisseur = fournisseur;
            Categorie = categorie;
            Nom = nom;
            PrixHT = prixHT;
            PrixTTC = prixTTC;
            Date = date;
            Quantite = quantite;
        }

        public string Reference { get => reference; set => reference = value; }
        public string Fournisseur { get => fournisseur; set => fournisseur = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public string Nom { get => nom; set => nom = value; }
        public decimal PrixHT { get => prixHT; set => prixHT = value; }
        public decimal PrixTTC { get => prixTTC; set => prixTTC = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Quantite { get => quantite; set => quantite = value; }
    }
}
