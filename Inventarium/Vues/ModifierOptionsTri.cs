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

namespace Inventarium.Vues
{
    public partial class ModifierOptionsTri : Form
    {
        public ModifierOptionsTri()
        {
            InitializeComponent();
            Chargement();
        }

        private void Chargement()
        {
            ListeOrdre.Items.Clear();

            string data = TriDataManager.Load();

            string[] categories = data.Split(';');

            for (int i = 0; i < categories.Length; i++)
            {
                if(categories[i] == "") continue;

                else if (categories[i] == "Fournisseur") CheckboxFournisseur.Checked = true;
                else if (categories[i] == "Catégorie") CheckboxCategorie.Checked = true;
                else if (categories[i] == "Nom") CheckboxNom.Checked = true;
                else if (categories[i] == "Date") CheckboxDate.Checked = true;
            }

            RearrangerOrdre();
        }

        private void Sauvegarder()
        {
            string str = "";

            for (int i = 0; i < ListeOrdre.Items.Count; i++)
            {
                str += ListeOrdre.Items[i].SubItems[1].Text + ";";
            }

            TriDataManager.Save(str);
        }

        private void RearrangerOrdre()
        {
            for (int i = 0; i < ListeOrdre.Items.Count; i++)
            {
                ListeOrdre.Items[i].SubItems[0].Text = (i+1).ToString();
            }

            Sauvegarder();
        }

        private void CheckboxFournisseur_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckboxFournisseur.Checked)
            {
                ListViewItem newItem = new ListViewItem("");
                newItem.SubItems.Add("Fournisseur");

                ListeOrdre.Items.Add(newItem);
            } else
            {
                Deselectionner();

                for (int i = 0; i < ListeOrdre.Items.Count; i++)
                {
                    if (ListeOrdre.Items[i].SubItems[1].Text == "Fournisseur") ListeOrdre.Items.RemoveAt(i);
                }
            }
            
            RearrangerOrdre();
        }

        private void CheckboxCategorie_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckboxCategorie.Checked)
            {
                ListViewItem newItem = new ListViewItem("");
                newItem.SubItems.Add("Catégorie");

                ListeOrdre.Items.Add(newItem);
            }
            else
            {
                Deselectionner();

                for (int i = 0; i < ListeOrdre.Items.Count; i++)
                {
                    if (ListeOrdre.Items[i].SubItems[1].Text == "Catégorie") ListeOrdre.Items.RemoveAt(i);
                }
            }

            RearrangerOrdre();
        }

        private void CheckboxNom_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckboxNom.Checked)
            {
                ListViewItem newItem = new ListViewItem("");
                newItem.SubItems.Add("Nom");

                ListeOrdre.Items.Add(newItem);
            }
            else
            {
                Deselectionner();

                for (int i = 0; i < ListeOrdre.Items.Count; i++)
                {
                    if (ListeOrdre.Items[i].SubItems[1].Text == "Nom") ListeOrdre.Items.RemoveAt(i);
                }
            }

            RearrangerOrdre();
        }

        private void CheckboxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckboxDate.Checked)
            {
                ListViewItem newItem = new ListViewItem("");
                newItem.SubItems.Add("Date");

                ListeOrdre.Items.Add(newItem);
            }
            else
            {
                Deselectionner();

                for (int i = 0; i < ListeOrdre.Items.Count; i++)
                {
                    if (ListeOrdre.Items[i].SubItems[1].Text == "Date") ListeOrdre.Items.RemoveAt(i);
                }
            }

            RearrangerOrdre();
        }

        private int lastSelected = -1;
        private void ListeOrdre_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            lastSelected = e.ItemIndex;
        }
        private void Deselectionner()
        {
            for (int i = 0; i < ListeOrdre.Items.Count; i++)
            {
                if (ListeOrdre.Items[i].Selected) ListeOrdre.Items[i].Selected = false;
            }

            lastSelected = -1;
        }

        private void BDescendre_Click(object sender, EventArgs e)
        {
            if (ListeOrdre.Items.Count == 0)
            {
                MessageBox.Show("Veuillez d'abord cocher des catégories pour les ajouter à la liste", "Attention !");
            }
            else if (lastSelected == -1)
            {
                MessageBox.Show("Veuillez sélectionner un élément dans la liste", "Attention !");
            }
            else if (lastSelected == ListeOrdre.Items.Count - 1)
            {
                MessageBox.Show("Veuillez selectionner un élément plus haut dans la liste", "Attention !");
            }
            else
            {
                (ListeOrdre.Items[lastSelected + 1].SubItems[1].Text, ListeOrdre.Items[lastSelected].SubItems[1].Text) = (ListeOrdre.Items[lastSelected].SubItems[1].Text, ListeOrdre.Items[lastSelected + 1].SubItems[1].Text);
                ListeOrdre.Items[lastSelected].Selected = false;
                ListeOrdre.Items[lastSelected + 1].Selected = true;

                Sauvegarder();
            }
        }

        private void BMonter_Click(object sender, EventArgs e)
        {
            if (ListeOrdre.Items.Count == 0)
            {
                MessageBox.Show("Veuillez d'abord cocher des catégories pour les ajouter à la liste", "Attention !");
            }
            else if (lastSelected == -1)
            {
                MessageBox.Show("Veuillez sélectionner un élément dans la liste", "Attention !");
            }
            else if (lastSelected == 0)
            {
                MessageBox.Show("Veuillez selectionner un élément plus bas dans la liste", "Attention !");
            }
            else
            {
                (ListeOrdre.Items[lastSelected - 1].SubItems[1].Text, ListeOrdre.Items[lastSelected].SubItems[1].Text) = (ListeOrdre.Items[lastSelected].SubItems[1].Text, ListeOrdre.Items[lastSelected - 1].SubItems[1].Text);
                ListeOrdre.Items[lastSelected].Selected = false;
                ListeOrdre.Items[lastSelected - 1].Selected = true;

                Sauvegarder();
            }
        }
    }
}
