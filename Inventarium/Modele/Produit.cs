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

        public Produit Clone()
        {
            return new Produit(
                    this.Reference,
                    this.Fournisseur,
                    this.Categorie,
                    this.Nom,
                    this.PrixHT,
                    this.PrixTTC,
                    this.date,
                    this.Quantite
                );
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
