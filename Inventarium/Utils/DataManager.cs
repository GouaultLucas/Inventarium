using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventarium.Utils
{
    internal class DataManager
    {
        readonly string csvPath = "Data/inventaire.csv";
        private bool DataFileExists()
        {
            return System.IO.File.Exists(csvPath);
        }
        private bool DataFolderExists()
        {
            return System.IO.Directory.Exists("Data");
        }
        public void PathChecks()
        {
            if (!DataFolderExists()) {
                System.IO.Directory.CreateDirectory("Data");
            }
            if(!DataFileExists())
            {
                System.IO.File.WriteAllText(csvPath, "");
            }
        }
        public List<Produit> LoadData()
        {
            List<Produit> produits = new List<Produit>();

            List<string> lines = System.IO.File.ReadAllLines(csvPath).ToList();

            foreach (string line in lines)
            {
                produits.Add(LineToProduit(line));
            }

            return produits;
        }
        public List<string> LoadLines()
        {
            List<string> lines = System.IO.File.ReadAllLines(csvPath).ToList();

            return lines;
        }
        private Produit LineToProduit(string line)
        {
            string[] valeurs = line.Split(';');

            string reference = valeurs[0],
                fournisseur = valeurs[1],
                categorie = valeurs[2],
                nom = valeurs[3];

            decimal.TryParse(valeurs[4], out decimal prixHT);
            decimal.TryParse(valeurs[5], out decimal prixTTC);

            string[] strDate = valeurs[6].Split('/');
            DateTime date = new DateTime(int.Parse(strDate[2]), int.Parse(strDate[1]), int.Parse(strDate[0]));

            int.TryParse(valeurs[7], out int quantite);

            Produit produit = new Produit(reference, fournisseur, categorie, nom, prixHT, prixTTC, date, quantite);

            return produit;
        }
        private string ProduitToLine(Produit produit)
        {
            string reference = produit.Reference,
                    fournisseur = produit.Fournisseur,
                    categorie = produit.Categorie,
                    nom = produit.Nom;

            decimal prixHT = produit.PrixHT,
                prixTTC = produit.PrixTTC;

            DateTime date = produit.Date;
            string strDate = date.Day.ToString() + "/" + date.Month.ToString() + "/" + date.Year.ToString();

            int quantite = produit.Quantite;

            string line = reference + ";" +
                fournisseur + ";" +
                categorie + ";" +
                nom + ";" +
                prixHT.ToString() + ";" +
                prixTTC.ToString() + ";" +
                strDate + ";" +
                quantite;

            Console.WriteLine(line);
            return line;
        }
        public void AjouterProduit(Produit produit)
        {
            List<string> lines = System.IO.File.ReadAllLines(csvPath).ToList();

            lines.Add(ProduitToLine(produit));

            System.IO.File.WriteAllLines(csvPath, lines);
        }
    }
}
