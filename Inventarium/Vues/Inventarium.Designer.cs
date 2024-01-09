namespace Inventarium
{
    partial class Inventarium
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LVProduit = new System.Windows.Forms.ListView();
            this.codeRef = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fournisseur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prixHT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prixTTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.BOuvrirTri = new System.Windows.Forms.Button();
            this.BAjouter = new System.Windows.Forms.Button();
            this.BVider = new System.Windows.Forms.Button();
            this.BRecherche = new System.Windows.Forms.Button();
            this.LbAvant = new System.Windows.Forms.Label();
            this.ChampAvant = new System.Windows.Forms.DateTimePicker();
            this.LbApres = new System.Windows.Forms.Label();
            this.ChampApres = new System.Windows.Forms.DateTimePicker();
            this.ChampNom = new System.Windows.Forms.TextBox();
            this.LbNom = new System.Windows.Forms.Label();
            this.ChampCateg = new System.Windows.Forms.TextBox();
            this.LbCateg = new System.Windows.Forms.Label();
            this.ChampFournisseur = new System.Windows.Forms.TextBox();
            this.LbFournisseur = new System.Windows.Forms.Label();
            this.ChampRef = new System.Windows.Forms.TextBox();
            this.LbRef = new System.Windows.Forms.Label();
            this.MenuContextuel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.modifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuContextuel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LVProduit
            // 
            this.LVProduit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codeRef,
            this.fournisseur,
            this.categorie,
            this.nom,
            this.prixHT,
            this.prixTTC,
            this.date,
            this.quantite});
            this.LVProduit.Dock = System.Windows.Forms.DockStyle.Top;
            this.LVProduit.FullRowSelect = true;
            this.LVProduit.GridLines = true;
            this.LVProduit.HideSelection = false;
            this.LVProduit.Location = new System.Drawing.Point(0, 0);
            this.LVProduit.Name = "LVProduit";
            this.LVProduit.Size = new System.Drawing.Size(987, 273);
            this.LVProduit.TabIndex = 0;
            this.LVProduit.TabStop = false;
            this.LVProduit.UseCompatibleStateImageBehavior = false;
            this.LVProduit.View = System.Windows.Forms.View.Details;
            this.LVProduit.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LVProduit_ItemSelectionChanged);
            this.LVProduit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LVProduit_MouseClick);
            // 
            // codeRef
            // 
            this.codeRef.Text = "Référence";
            this.codeRef.Width = 145;
            // 
            // fournisseur
            // 
            this.fournisseur.Text = "Fournisseur";
            this.fournisseur.Width = 100;
            // 
            // categorie
            // 
            this.categorie.Text = "Catégorie";
            this.categorie.Width = 82;
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 140;
            // 
            // prixHT
            // 
            this.prixHT.Text = "Prix HT";
            // 
            // prixTTC
            // 
            this.prixTTC.Text = "Prix TTC";
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 76;
            // 
            // quantite
            // 
            this.quantite.Text = "Quantité";
            this.quantite.Width = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rechercher";
            // 
            // BOuvrirTri
            // 
            this.BOuvrirTri.Location = new System.Drawing.Point(792, 285);
            this.BOuvrirTri.Name = "BOuvrirTri";
            this.BOuvrirTri.Size = new System.Drawing.Size(183, 35);
            this.BOuvrirTri.TabIndex = 8;
            this.BOuvrirTri.Text = "Ouvrir les options de tri";
            this.BOuvrirTri.UseVisualStyleBackColor = true;
            this.BOuvrirTri.Click += new System.EventHandler(this.BOuvrirTri_Click);
            // 
            // BAjouter
            // 
            this.BAjouter.Location = new System.Drawing.Point(15, 390);
            this.BAjouter.Name = "BAjouter";
            this.BAjouter.Size = new System.Drawing.Size(163, 35);
            this.BAjouter.TabIndex = 9;
            this.BAjouter.Text = "Ajouter un produit";
            this.BAjouter.UseVisualStyleBackColor = true;
            this.BAjouter.Click += new System.EventHandler(this.BAjouter_Click);
            // 
            // BVider
            // 
            this.BVider.Location = new System.Drawing.Point(792, 390);
            this.BVider.Name = "BVider";
            this.BVider.Size = new System.Drawing.Size(183, 35);
            this.BVider.TabIndex = 7;
            this.BVider.Text = "Vider les champs";
            this.BVider.UseVisualStyleBackColor = true;
            this.BVider.Click += new System.EventHandler(this.BVider_Click);
            // 
            // BRecherche
            // 
            this.BRecherche.Location = new System.Drawing.Point(792, 340);
            this.BRecherche.Name = "BRecherche";
            this.BRecherche.Size = new System.Drawing.Size(183, 35);
            this.BRecherche.TabIndex = 6;
            this.BRecherche.Text = "Rechercher";
            this.BRecherche.UseVisualStyleBackColor = true;
            this.BRecherche.Click += new System.EventHandler(this.Rechercher);
            // 
            // LbAvant
            // 
            this.LbAvant.AutoSize = true;
            this.LbAvant.Location = new System.Drawing.Point(477, 375);
            this.LbAvant.Name = "LbAvant";
            this.LbAvant.Size = new System.Drawing.Size(41, 16);
            this.LbAvant.TabIndex = 15;
            this.LbAvant.Text = "Avant";
            // 
            // ChampAvant
            // 
            this.ChampAvant.Checked = false;
            this.ChampAvant.Location = new System.Drawing.Point(480, 394);
            this.ChampAvant.Name = "ChampAvant";
            this.ChampAvant.ShowCheckBox = true;
            this.ChampAvant.Size = new System.Drawing.Size(254, 22);
            this.ChampAvant.TabIndex = 5;
            // 
            // LbApres
            // 
            this.LbApres.AutoSize = true;
            this.LbApres.Location = new System.Drawing.Point(477, 324);
            this.LbApres.Name = "LbApres";
            this.LbApres.Size = new System.Drawing.Size(43, 16);
            this.LbApres.TabIndex = 13;
            this.LbApres.Text = "Après";
            // 
            // ChampApres
            // 
            this.ChampApres.Checked = false;
            this.ChampApres.Location = new System.Drawing.Point(480, 343);
            this.ChampApres.Name = "ChampApres";
            this.ChampApres.ShowCheckBox = true;
            this.ChampApres.Size = new System.Drawing.Size(254, 22);
            this.ChampApres.TabIndex = 4;
            // 
            // ChampNom
            // 
            this.ChampNom.Location = new System.Drawing.Point(365, 343);
            this.ChampNom.Name = "ChampNom";
            this.ChampNom.Size = new System.Drawing.Size(100, 22);
            this.ChampNom.TabIndex = 3;
            // 
            // LbNom
            // 
            this.LbNom.AutoSize = true;
            this.LbNom.Location = new System.Drawing.Point(362, 324);
            this.LbNom.Name = "LbNom";
            this.LbNom.Size = new System.Drawing.Size(36, 16);
            this.LbNom.TabIndex = 8;
            this.LbNom.Text = "Nom";
            // 
            // ChampCateg
            // 
            this.ChampCateg.Location = new System.Drawing.Point(249, 343);
            this.ChampCateg.Name = "ChampCateg";
            this.ChampCateg.Size = new System.Drawing.Size(100, 22);
            this.ChampCateg.TabIndex = 2;
            // 
            // LbCateg
            // 
            this.LbCateg.AutoSize = true;
            this.LbCateg.Location = new System.Drawing.Point(246, 324);
            this.LbCateg.Name = "LbCateg";
            this.LbCateg.Size = new System.Drawing.Size(66, 16);
            this.LbCateg.TabIndex = 6;
            this.LbCateg.Text = "Catégorie";
            // 
            // ChampFournisseur
            // 
            this.ChampFournisseur.Location = new System.Drawing.Point(132, 343);
            this.ChampFournisseur.Name = "ChampFournisseur";
            this.ChampFournisseur.Size = new System.Drawing.Size(100, 22);
            this.ChampFournisseur.TabIndex = 1;
            // 
            // LbFournisseur
            // 
            this.LbFournisseur.AutoSize = true;
            this.LbFournisseur.Location = new System.Drawing.Point(129, 324);
            this.LbFournisseur.Name = "LbFournisseur";
            this.LbFournisseur.Size = new System.Drawing.Size(77, 16);
            this.LbFournisseur.TabIndex = 4;
            this.LbFournisseur.Text = "Fournisseur";
            // 
            // ChampRef
            // 
            this.ChampRef.Location = new System.Drawing.Point(15, 343);
            this.ChampRef.Name = "ChampRef";
            this.ChampRef.Size = new System.Drawing.Size(100, 22);
            this.ChampRef.TabIndex = 0;
            // 
            // LbRef
            // 
            this.LbRef.AutoSize = true;
            this.LbRef.Location = new System.Drawing.Point(12, 324);
            this.LbRef.Name = "LbRef";
            this.LbRef.Size = new System.Drawing.Size(70, 16);
            this.LbRef.TabIndex = 2;
            this.LbRef.Text = "Référence";
            // 
            // MenuContextuel
            // 
            this.MenuContextuel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuContextuel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.toolStripSeparator1,
            this.modifierToolStripMenuItem1,
            this.supprimerToolStripMenuItem1});
            this.MenuContextuel.Name = "MenuContextuel";
            this.MenuContextuel.Size = new System.Drawing.Size(148, 106);
            this.MenuContextuel.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuContextuel_ItemClicked);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.modifierToolStripMenuItem.Text = "Ajouter";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.supprimerToolStripMenuItem.Text = "Enlever";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.SupprimerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(147, 24);
            this.modifierToolStripMenuItem1.Text = "Modifier";
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(147, 24);
            this.supprimerToolStripMenuItem1.Text = "Supprimer";
            // 
            // Inventarium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(987, 448);
            this.Controls.Add(this.BVider);
            this.Controls.Add(this.BAjouter);
            this.Controls.Add(this.BOuvrirTri);
            this.Controls.Add(this.LbAvant);
            this.Controls.Add(this.BRecherche);
            this.Controls.Add(this.ChampAvant);
            this.Controls.Add(this.LbApres);
            this.Controls.Add(this.LVProduit);
            this.Controls.Add(this.ChampApres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChampNom);
            this.Controls.Add(this.LbRef);
            this.Controls.Add(this.LbNom);
            this.Controls.Add(this.ChampRef);
            this.Controls.Add(this.ChampCateg);
            this.Controls.Add(this.LbFournisseur);
            this.Controls.Add(this.LbCateg);
            this.Controls.Add(this.ChampFournisseur);
            this.KeyPreview = true;
            this.Name = "Inventarium";
            this.Text = "Inventarium";
            this.Load += new System.EventHandler(this.Inventarium_Load);
            this.Shown += new System.EventHandler(this.Inventarium_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Inventarium_KeyDown);
            this.MenuContextuel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVProduit;
        private System.Windows.Forms.ColumnHeader codeRef;
        private System.Windows.Forms.ColumnHeader fournisseur;
        private System.Windows.Forms.ColumnHeader categorie;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader prixHT;
        private System.Windows.Forms.ColumnHeader prixTTC;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader quantite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbRef;
        private System.Windows.Forms.TextBox ChampRef;
        private System.Windows.Forms.TextBox ChampFournisseur;
        private System.Windows.Forms.Label LbFournisseur;
        private System.Windows.Forms.DateTimePicker ChampApres;
        private System.Windows.Forms.TextBox ChampNom;
        private System.Windows.Forms.Label LbNom;
        private System.Windows.Forms.TextBox ChampCateg;
        private System.Windows.Forms.Label LbCateg;
        private System.Windows.Forms.Label LbAvant;
        private System.Windows.Forms.DateTimePicker ChampAvant;
        private System.Windows.Forms.Label LbApres;
        private System.Windows.Forms.Button BRecherche;
        private System.Windows.Forms.Button BVider;
        private System.Windows.Forms.Button BAjouter;
        private System.Windows.Forms.ContextMenuStrip MenuContextuel;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button BOuvrirTri;
    }
}

