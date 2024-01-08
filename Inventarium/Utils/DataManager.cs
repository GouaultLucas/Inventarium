using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventarium.Utils
{
    internal class DataManager
    {
        readonly static string csvPath = "Data/inventaire.csv";
        private static bool DataFileExists()
        {
            return System.IO.File.Exists(csvPath);
        }
        private static bool DataFolderExists()
        {
            return System.IO.Directory.Exists("Data");
        }
        public static void PathChecks()
        {
            if (!DataFolderExists()) {
                System.IO.Directory.CreateDirectory("Data");
            }
            if(!DataFileExists())
            {
                System.IO.File.WriteAllText(csvPath, "");
            }
        }
        public static List<Produit> LoadData()
        {
            List<Produit> produits = new List<Produit>();

            List<string> lines = LoadLines();

            foreach (string line in lines)
            {
                produits.Add(LineToProduit(line));
            }

            return produits;
        }
        public static List<string> LoadLines()
        {
            PathChecks();

            List<string> lines = System.IO.File.ReadAllLines(csvPath).ToList();

            return lines;
        }
        public static Produit LineToProduit(string line)
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
        public static ListViewItem LineToItem(string line)
        {
            Produit produit = LineToProduit(line);

            ListViewItem item = new ListViewItem(produit.Reference);
            item.SubItems.Add(produit.Fournisseur);
            item.SubItems.Add(produit.Categorie);
            item.SubItems.Add(produit.Nom);
            item.SubItems.Add(produit.PrixHT.ToString());
            item.SubItems.Add(produit.PrixTTC.ToString());
            item.SubItems.Add(line.Split(';')[6]);
            item.SubItems.Add(produit.Quantite.ToString());

            return item;
        }
        public static string ItemToLine(ListViewItem item)
        {
            string reference = item.SubItems[0].Text,
                    fournisseur = item.SubItems[1].Text,
                    categorie = item.SubItems[2].Text,
                    nom = item.SubItems[3].Text;

            decimal.TryParse(item.SubItems[4].Text, out decimal prixHT);
            decimal.TryParse(item.SubItems[5].Text, out decimal prixTTC);

            string strDate = item.SubItems[6].Text;

            int.TryParse(item.SubItems[7].Text, out int quantite);

            string line = reference + ";" +
                fournisseur + ";" +
                categorie + ";" +
                nom + ";" +
                prixHT.ToString() + ";" +
                prixTTC.ToString() + ";" +
                strDate + ";" +
                quantite;

            return line;
        }
        public static string ProduitToLine(Produit produit)
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

            return line;
        }
        public static void AjouterProduit(Produit produit)
        {
            List<string> lines = LoadLines();

            lines.Add(ProduitToLine(produit));

            System.IO.File.WriteAllLines(csvPath, lines);
        }
        public static void ModifierProduit(Produit produitAvant, Produit produitApres)
        {
            List<string> lines = LoadLines();

            for(int i = 0; i < lines.Count; i++)
            {
                Produit produit = LineToProduit(lines[i]);

                if (ProduitToLine(produit).Equals(ProduitToLine(produitAvant)))
                {
                    lines[i] = ProduitToLine(produitApres);
                }
            }

            System.IO.File.WriteAllLines(csvPath, lines);
        }

        public static void SupprimerProduit(Produit produit)
        {
            List<string> lines = LoadLines();

            lines.Remove(ProduitToLine(produit));

            System.IO.File.WriteAllLines(csvPath, lines);
        }
    }
}