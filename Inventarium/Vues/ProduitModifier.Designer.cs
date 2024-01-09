namespace Inventarium.Vues
{
    partial class ProduitModifier
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
            this.LbAjouter = new System.Windows.Forms.Label();
            this.BReset = new System.Windows.Forms.Button();
            this.BModifier = new System.Windows.Forms.Button();
            this.LbQuantite = new System.Windows.Forms.Label();
            this.ChampQuantite = new System.Windows.Forms.NumericUpDown();
            this.ChampDate = new System.Windows.Forms.DateTimePicker();
            this.LbDate = new System.Windows.Forms.Label();
            this.LbPrixTTC = new System.Windows.Forms.Label();
            this.ChampPrixTTC = new System.Windows.Forms.NumericUpDown();
            this.LbPrixHT = new System.Windows.Forms.Label();
            this.ChampPrixHT = new System.Windows.Forms.NumericUpDown();
            this.ChampNom = new System.Windows.Forms.TextBox();
            this.LbNom = new System.Windows.Forms.Label();
            this.ChampCategorie = new System.Windows.Forms.TextBox();
            this.LbCategorie = new System.Windows.Forms.Label();
            this.ChampFournisseur = new System.Windows.Forms.TextBox();
            this.LbFournisseur = new System.Windows.Forms.Label();
            this.ChampRef = new System.Windows.Forms.TextBox();
            this.LbRef = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChampQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChampPrixTTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChampPrixHT)).BeginInit();
            this.SuspendLayout();
            // 
            // LbAjouter
            // 
            this.LbAjouter.AutoSize = true;
            this.LbAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAjouter.Location = new System.Drawing.Point(136, 39);
            this.LbAjouter.Name = "LbAjouter";
            this.LbAjouter.Size = new System.Drawing.Size(269, 32);
            this.LbAjouter.TabIndex = 1;
            this.LbAjouter.Text = "Modifier un produit";
            // 
            // BReset
            // 
            this.BReset.Location = new System.Drawing.Point(69, 337);
            this.BReset.Name = "BReset";
            this.BReset.Size = new System.Drawing.Size(181, 35);
            this.BReset.TabIndex = 9;
            this.BReset.Text = "Réinitialiser les champs";
            this.BReset.UseVisualStyleBackColor = true;
            this.BReset.Click += new System.EventHandler(this.BReset_Click);
            // 
            // BModifier
            // 
            this.BModifier.Location = new System.Drawing.Point(296, 337);
            this.BModifier.Name = "BModifier";
            this.BModifier.Size = new System.Drawing.Size(181, 35);
            this.BModifier.TabIndex = 8;
            this.BModifier.Text = "Modifier le produit";
            this.BModifier.UseVisualStyleBackColor = true;
            this.BModifier.Click += new System.EventHandler(this.BModifier_Click);
            // 
            // LbQuantite
            // 
            this.LbQuantite.AutoSize = true;
            this.LbQuantite.Location = new System.Drawing.Point(66, 299);
            this.LbQuantite.Name = "LbQuantite";
            this.LbQuantite.Size = new System.Drawing.Size(56, 16);
            this.LbQuantite.TabIndex = 36;
            this.LbQuantite.Text = "Quantité";
            // 
            // ChampQuantite
            // 
            this.ChampQuantite.Location = new System.Drawing.Point(223, 297);
            this.ChampQuantite.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ChampQuantite.Name = "ChampQuantite";
            this.ChampQuantite.Size = new System.Drawing.Size(254, 22);
            this.ChampQuantite.TabIndex = 7;
            this.ChampQuantite.ThousandsSeparator = true;
            // 
            // ChampDate
            // 
            this.ChampDate.Location = new System.Drawing.Point(223, 269);
            this.ChampDate.Name = "ChampDate";
            this.ChampDate.Size = new System.Drawing.Size(254, 22);
            this.ChampDate.TabIndex = 6;
            // 
            // LbDate
            // 
            this.LbDate.AutoSize = true;
            this.LbDate.Location = new System.Drawing.Point(66, 274);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(36, 16);
            this.LbDate.TabIndex = 33;
            this.LbDate.Text = "Date";
            // 
            // LbPrixTTC
            // 
            this.LbPrixTTC.AutoSize = true;
            this.LbPrixTTC.Location = new System.Drawing.Point(66, 243);
            this.LbPrixTTC.Name = "LbPrixTTC";
            this.LbPrixTTC.Size = new System.Drawing.Size(56, 16);
            this.LbPrixTTC.TabIndex = 32;
            this.LbPrixTTC.Text = "PrixTTC";
            // 
            // ChampPrixTTC
            // 
            this.ChampPrixTTC.DecimalPlaces = 2;
            this.ChampPrixTTC.Location = new System.Drawing.Point(223, 241);
            this.ChampPrixTTC.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ChampPrixTTC.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.ChampPrixTTC.Name = "ChampPrixTTC";
            this.ChampPrixTTC.Size = new System.Drawing.Size(254, 22);
            this.ChampPrixTTC.TabIndex = 5;
            this.ChampPrixTTC.ThousandsSeparator = true;
            this.ChampPrixTTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown_KeyPress);
            // 
            // LbPrixHT
            // 
            this.LbPrixHT.AutoSize = true;
            this.LbPrixHT.Location = new System.Drawing.Point(66, 215);
            this.LbPrixHT.Name = "LbPrixHT";
            this.LbPrixHT.Size = new System.Drawing.Size(48, 16);
            this.LbPrixHT.TabIndex = 30;
            this.LbPrixHT.Text = "PrixHT";
            // 
            // ChampPrixHT
            // 
            this.ChampPrixHT.DecimalPlaces = 2;
            this.ChampPrixHT.Location = new System.Drawing.Point(223, 213);
            this.ChampPrixHT.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ChampPrixHT.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.ChampPrixHT.Name = "ChampPrixHT";
            this.ChampPrixHT.Size = new System.Drawing.Size(254, 22);
            this.ChampPrixHT.TabIndex = 4;
            this.ChampPrixHT.ThousandsSeparator = true;
            this.ChampPrixHT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown_KeyPress);
            // 
            // ChampNom
            // 
            this.ChampNom.Location = new System.Drawing.Point(223, 185);
            this.ChampNom.Name = "ChampNom";
            this.ChampNom.Size = new System.Drawing.Size(254, 22);
            this.ChampNom.TabIndex = 3;
            // 
            // LbNom
            // 
            this.LbNom.AutoSize = true;
            this.LbNom.Location = new System.Drawing.Point(66, 188);
            this.LbNom.Name = "LbNom";
            this.LbNom.Size = new System.Drawing.Size(36, 16);
            this.LbNom.TabIndex = 27;
            this.LbNom.Text = "Nom";
            // 
            // ChampCategorie
            // 
            this.ChampCategorie.Location = new System.Drawing.Point(223, 157);
            this.ChampCategorie.Name = "ChampCategorie";
            this.ChampCategorie.Size = new System.Drawing.Size(254, 22);
            this.ChampCategorie.TabIndex = 2;
            // 
            // LbCategorie
            // 
            this.LbCategorie.AutoSize = true;
            this.LbCategorie.Location = new System.Drawing.Point(66, 160);
            this.LbCategorie.Name = "LbCategorie";
            this.LbCategorie.Size = new System.Drawing.Size(66, 16);
            this.LbCategorie.TabIndex = 25;
            this.LbCategorie.Text = "Catégorie";
            // 
            // ChampFournisseur
            // 
            this.ChampFournisseur.Location = new System.Drawing.Point(223, 129);
            this.ChampFournisseur.Name = "ChampFournisseur";
            this.ChampFournisseur.Size = new System.Drawing.Size(254, 22);
            this.ChampFournisseur.TabIndex = 1;
            // 
            // LbFournisseur
            // 
            this.LbFournisseur.AutoSize = true;
            this.LbFournisseur.Location = new System.Drawing.Point(66, 132);
            this.LbFournisseur.Name = "LbFournisseur";
            this.LbFournisseur.Size = new System.Drawing.Size(77, 16);
            this.LbFournisseur.TabIndex = 23;
            this.LbFournisseur.Text = "Fournisseur";
            // 
            // ChampRef
            // 
            this.ChampRef.Location = new System.Drawing.Point(223, 101);
            this.ChampRef.Name = "ChampRef";
            this.ChampRef.Size = new System.Drawing.Size(254, 22);
            this.ChampRef.TabIndex = 0;
            // 
            // LbRef
            // 
            this.LbRef.AutoSize = true;
            this.LbRef.Location = new System.Drawing.Point(66, 104);
            this.LbRef.Name = "LbRef";
            this.LbRef.Size = new System.Drawing.Size(70, 16);
            this.LbRef.TabIndex = 21;
            this.LbRef.Text = "Référence";
            // 
            // ProduitModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(544, 411);
            this.Controls.Add(this.BReset);
            this.Controls.Add(this.BModifier);
            this.Controls.Add(this.LbQuantite);
            this.Controls.Add(this.ChampQuantite);
            this.Controls.Add(this.ChampDate);
            this.Controls.Add(this.LbDate);
            this.Controls.Add(this.LbPrixTTC);
            this.Controls.Add(this.ChampPrixTTC);
            this.Controls.Add(this.LbPrixHT);
            this.Controls.Add(this.ChampPrixHT);
            this.Controls.Add(this.ChampNom);
            this.Controls.Add(this.LbNom);
            this.Controls.Add(this.ChampCategorie);
            this.Controls.Add(this.LbCategorie);
            this.Controls.Add(this.ChampFournisseur);
            this.Controls.Add(this.LbFournisseur);
            this.Controls.Add(this.ChampRef);
            this.Controls.Add(this.LbRef);
            this.Controls.Add(this.LbAjouter);
            this.KeyPreview = true;
            this.Name = "ProduitModifier";
            this.Text = "Modifier un produit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProduitModifier_FormClosing);
            this.Load += new System.EventHandler(this.ProduitModifier_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProduitModifier_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ChampQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChampPrixTTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChampPrixHT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbAjouter;
        private System.Windows.Forms.Button BReset;
        private System.Windows.Forms.Button BModifier;
        private System.Windows.Forms.Label LbQuantite;
        private System.Windows.Forms.NumericUpDown ChampQuantite;
        private System.Windows.Forms.DateTimePicker ChampDate;
        private System.Windows.Forms.Label LbDate;
        private System.Windows.Forms.Label LbPrixTTC;
        private System.Windows.Forms.NumericUpDown ChampPrixTTC;
        private System.Windows.Forms.Label LbPrixHT;
        private System.Windows.Forms.NumericUpDown ChampPrixHT;
        private System.Windows.Forms.TextBox ChampNom;
        private System.Windows.Forms.Label LbNom;
        private System.Windows.Forms.TextBox ChampCategorie;
        private System.Windows.Forms.Label LbCategorie;
        private System.Windows.Forms.TextBox ChampFournisseur;
        private System.Windows.Forms.Label LbFournisseur;
        private System.Windows.Forms.TextBox ChampRef;
        private System.Windows.Forms.Label LbRef;
    }
}