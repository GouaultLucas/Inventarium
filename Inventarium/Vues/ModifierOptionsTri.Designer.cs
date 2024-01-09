namespace Inventarium.Vues
{
    partial class ModifierOptionsTri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListeOrdre = new System.Windows.Forms.ListView();
            this.ordre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTitre = new System.Windows.Forms.Label();
            this.CheckboxFournisseur = new System.Windows.Forms.CheckBox();
            this.CheckboxCategorie = new System.Windows.Forms.CheckBox();
            this.CheckboxNom = new System.Windows.Forms.CheckBox();
            this.CheckboxDate = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BDescendre = new System.Windows.Forms.Button();
            this.BMonter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListeOrdre
            // 
            this.ListeOrdre.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ordre,
            this.nom});
            this.ListeOrdre.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListeOrdre.FullRowSelect = true;
            this.ListeOrdre.GridLines = true;
            this.ListeOrdre.HideSelection = false;
            this.ListeOrdre.Location = new System.Drawing.Point(0, 0);
            this.ListeOrdre.Name = "ListeOrdre";
            this.ListeOrdre.Size = new System.Drawing.Size(230, 365);
            this.ListeOrdre.TabIndex = 0;
            this.ListeOrdre.TabStop = false;
            this.ListeOrdre.UseCompatibleStateImageBehavior = false;
            this.ListeOrdre.View = System.Windows.Forms.View.Details;
            this.ListeOrdre.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListeOrdre_ItemSelectionChanged);
            // 
            // ordre
            // 
            this.ordre.Text = "Ordre";
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 120;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(258, 23);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(311, 29);
            this.labelTitre.TabIndex = 1;
            this.labelTitre.Text = "Modifier les options de tri";
            // 
            // CheckboxFournisseur
            // 
            this.CheckboxFournisseur.AutoSize = true;
            this.CheckboxFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckboxFournisseur.Location = new System.Drawing.Point(293, 75);
            this.CheckboxFournisseur.Name = "CheckboxFournisseur";
            this.CheckboxFournisseur.Size = new System.Drawing.Size(120, 24);
            this.CheckboxFournisseur.TabIndex = 0;
            this.CheckboxFournisseur.Text = "Fournisseur";
            this.CheckboxFournisseur.UseVisualStyleBackColor = true;
            this.CheckboxFournisseur.CheckedChanged += new System.EventHandler(this.CheckboxFournisseur_CheckedChanged);
            // 
            // CheckboxCategorie
            // 
            this.CheckboxCategorie.AutoSize = true;
            this.CheckboxCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckboxCategorie.Location = new System.Drawing.Point(293, 105);
            this.CheckboxCategorie.Name = "CheckboxCategorie";
            this.CheckboxCategorie.Size = new System.Drawing.Size(103, 24);
            this.CheckboxCategorie.TabIndex = 1;
            this.CheckboxCategorie.Text = "Catégorie";
            this.CheckboxCategorie.UseVisualStyleBackColor = true;
            this.CheckboxCategorie.CheckedChanged += new System.EventHandler(this.CheckboxCategorie_CheckedChanged);
            // 
            // CheckboxNom
            // 
            this.CheckboxNom.AutoSize = true;
            this.CheckboxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckboxNom.Location = new System.Drawing.Point(293, 135);
            this.CheckboxNom.Name = "CheckboxNom";
            this.CheckboxNom.Size = new System.Drawing.Size(66, 24);
            this.CheckboxNom.TabIndex = 2;
            this.CheckboxNom.Text = "Nom";
            this.CheckboxNom.UseVisualStyleBackColor = true;
            this.CheckboxNom.CheckedChanged += new System.EventHandler(this.CheckboxNom_CheckedChanged);
            // 
            // CheckboxDate
            // 
            this.CheckboxDate.AutoSize = true;
            this.CheckboxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckboxDate.Location = new System.Drawing.Point(293, 165);
            this.CheckboxDate.Name = "CheckboxDate";
            this.CheckboxDate.Size = new System.Drawing.Size(67, 24);
            this.CheckboxDate.TabIndex = 3;
            this.CheckboxDate.Text = "Date";
            this.CheckboxDate.UseVisualStyleBackColor = true;
            this.CheckboxDate.CheckedChanged += new System.EventHandler(this.CheckboxDate_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Changer l\'ordre de tri de la catégorie";
            // 
            // BDescendre
            // 
            this.BDescendre.Location = new System.Drawing.Point(293, 273);
            this.BDescendre.Name = "BDescendre";
            this.BDescendre.Size = new System.Drawing.Size(178, 54);
            this.BDescendre.TabIndex = 4;
            this.BDescendre.Text = "Descendre d\'un cran la catégorie sélectionnée";
            this.BDescendre.UseVisualStyleBackColor = true;
            this.BDescendre.Click += new System.EventHandler(this.BDescendre_Click);
            // 
            // BMonter
            // 
            this.BMonter.Location = new System.Drawing.Point(506, 273);
            this.BMonter.Name = "BMonter";
            this.BMonter.Size = new System.Drawing.Size(178, 54);
            this.BMonter.TabIndex = 5;
            this.BMonter.Text = "Monter d\'un cran la catégorie sélectionnée";
            this.BMonter.UseVisualStyleBackColor = true;
            this.BMonter.Click += new System.EventHandler(this.BMonter_Click);
            // 
            // ModifierOptionsTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(755, 365);
            this.Controls.Add(this.BMonter);
            this.Controls.Add(this.BDescendre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckboxDate);
            this.Controls.Add(this.CheckboxNom);
            this.Controls.Add(this.CheckboxCategorie);
            this.Controls.Add(this.CheckboxFournisseur);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.ListeOrdre);
            this.Name = "ModifierOptionsTri";
            this.Text = "Modifier les options de tri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListeOrdre;
        private System.Windows.Forms.ColumnHeader ordre;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.CheckBox CheckboxFournisseur;
        private System.Windows.Forms.CheckBox CheckboxCategorie;
        private System.Windows.Forms.CheckBox CheckboxNom;
        private System.Windows.Forms.CheckBox CheckboxDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BDescendre;
        private System.Windows.Forms.Button BMonter;
    }
}