namespace Inventarium
{
    partial class ProduitAjouter
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
            this.LbRef = new System.Windows.Forms.Label();
            this.TRef = new System.Windows.Forms.TextBox();
            this.TFournisseur = new System.Windows.Forms.TextBox();
            this.LbFournisseur = new System.Windows.Forms.Label();
            this.TCategorie = new System.Windows.Forms.TextBox();
            this.LbCategorie = new System.Windows.Forms.Label();
            this.TNom = new System.Windows.Forms.TextBox();
            this.LbNom = new System.Windows.Forms.Label();
            this.NPrixHT = new System.Windows.Forms.NumericUpDown();
            this.LbPrixHT = new System.Windows.Forms.Label();
            this.LbPrixTTC = new System.Windows.Forms.Label();
            this.NPrixTTC = new System.Windows.Forms.NumericUpDown();
            this.LbDate = new System.Windows.Forms.Label();
            this.DTDate = new System.Windows.Forms.DateTimePicker();
            this.NQuantite = new System.Windows.Forms.NumericUpDown();
            this.LbQuantite = new System.Windows.Forms.Label();
            this.BAjouter = new System.Windows.Forms.Button();
            this.BVider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NPrixHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPrixTTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // LbAjouter
            // 
            this.LbAjouter.AutoSize = true;
            this.LbAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAjouter.Location = new System.Drawing.Point(12, 9);
            this.LbAjouter.Name = "LbAjouter";
            this.LbAjouter.Size = new System.Drawing.Size(257, 32);
            this.LbAjouter.TabIndex = 0;
            this.LbAjouter.Text = "Ajouter un produit";
            // 
            // LbRef
            // 
            this.LbRef.AutoSize = true;
            this.LbRef.Location = new System.Drawing.Point(15, 64);
            this.LbRef.Name = "LbRef";
            this.LbRef.Size = new System.Drawing.Size(70, 16);
            this.LbRef.TabIndex = 1;
            this.LbRef.Text = "Référence";
            // 
            // TRef
            // 
            this.TRef.Location = new System.Drawing.Point(172, 61);
            this.TRef.Name = "TRef";
            this.TRef.Size = new System.Drawing.Size(254, 22);
            this.TRef.TabIndex = 2;
            // 
            // TFournisseur
            // 
            this.TFournisseur.Location = new System.Drawing.Point(172, 89);
            this.TFournisseur.Name = "TFournisseur";
            this.TFournisseur.Size = new System.Drawing.Size(254, 22);
            this.TFournisseur.TabIndex = 4;
            // 
            // LbFournisseur
            // 
            this.LbFournisseur.AutoSize = true;
            this.LbFournisseur.Location = new System.Drawing.Point(15, 92);
            this.LbFournisseur.Name = "LbFournisseur";
            this.LbFournisseur.Size = new System.Drawing.Size(77, 16);
            this.LbFournisseur.TabIndex = 3;
            this.LbFournisseur.Text = "Fournisseur";
            // 
            // TCategorie
            // 
            this.TCategorie.Location = new System.Drawing.Point(172, 117);
            this.TCategorie.Name = "TCategorie";
            this.TCategorie.Size = new System.Drawing.Size(254, 22);
            this.TCategorie.TabIndex = 6;
            // 
            // LbCategorie
            // 
            this.LbCategorie.AutoSize = true;
            this.LbCategorie.Location = new System.Drawing.Point(15, 120);
            this.LbCategorie.Name = "LbCategorie";
            this.LbCategorie.Size = new System.Drawing.Size(66, 16);
            this.LbCategorie.TabIndex = 5;
            this.LbCategorie.Text = "Catégorie";
            // 
            // TNom
            // 
            this.TNom.Location = new System.Drawing.Point(172, 145);
            this.TNom.Name = "TNom";
            this.TNom.Size = new System.Drawing.Size(254, 22);
            this.TNom.TabIndex = 8;
            // 
            // LbNom
            // 
            this.LbNom.AutoSize = true;
            this.LbNom.Location = new System.Drawing.Point(15, 148);
            this.LbNom.Name = "LbNom";
            this.LbNom.Size = new System.Drawing.Size(36, 16);
            this.LbNom.TabIndex = 7;
            this.LbNom.Text = "Nom";
            // 
            // NPrixHT
            // 
            this.NPrixHT.DecimalPlaces = 2;
            this.NPrixHT.Location = new System.Drawing.Point(172, 173);
            this.NPrixHT.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NPrixHT.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.NPrixHT.Name = "NPrixHT";
            this.NPrixHT.Size = new System.Drawing.Size(254, 22);
            this.NPrixHT.TabIndex = 9;
            this.NPrixHT.ThousandsSeparator = true;
            // 
            // LbPrixHT
            // 
            this.LbPrixHT.AutoSize = true;
            this.LbPrixHT.Location = new System.Drawing.Point(15, 175);
            this.LbPrixHT.Name = "LbPrixHT";
            this.LbPrixHT.Size = new System.Drawing.Size(48, 16);
            this.LbPrixHT.TabIndex = 10;
            this.LbPrixHT.Text = "PrixHT";
            // 
            // LbPrixTTC
            // 
            this.LbPrixTTC.AutoSize = true;
            this.LbPrixTTC.Location = new System.Drawing.Point(15, 203);
            this.LbPrixTTC.Name = "LbPrixTTC";
            this.LbPrixTTC.Size = new System.Drawing.Size(56, 16);
            this.LbPrixTTC.TabIndex = 12;
            this.LbPrixTTC.Text = "PrixTTC";
            // 
            // NPrixTTC
            // 
            this.NPrixTTC.DecimalPlaces = 2;
            this.NPrixTTC.Location = new System.Drawing.Point(172, 201);
            this.NPrixTTC.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NPrixTTC.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.NPrixTTC.Name = "NPrixTTC";
            this.NPrixTTC.Size = new System.Drawing.Size(254, 22);
            this.NPrixTTC.TabIndex = 11;
            this.NPrixTTC.ThousandsSeparator = true;
            // 
            // LbDate
            // 
            this.LbDate.AutoSize = true;
            this.LbDate.Location = new System.Drawing.Point(15, 234);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(36, 16);
            this.LbDate.TabIndex = 13;
            this.LbDate.Text = "Date";
            // 
            // DTDate
            // 
            this.DTDate.Location = new System.Drawing.Point(172, 229);
            this.DTDate.Name = "DTDate";
            this.DTDate.Size = new System.Drawing.Size(254, 22);
            this.DTDate.TabIndex = 14;
            // 
            // NQuantite
            // 
            this.NQuantite.Location = new System.Drawing.Point(172, 257);
            this.NQuantite.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NQuantite.Name = "NQuantite";
            this.NQuantite.Size = new System.Drawing.Size(254, 22);
            this.NQuantite.TabIndex = 15;
            this.NQuantite.ThousandsSeparator = true;
            // 
            // LbQuantite
            // 
            this.LbQuantite.AutoSize = true;
            this.LbQuantite.Location = new System.Drawing.Point(15, 259);
            this.LbQuantite.Name = "LbQuantite";
            this.LbQuantite.Size = new System.Drawing.Size(56, 16);
            this.LbQuantite.TabIndex = 16;
            this.LbQuantite.Text = "Quantité";
            // 
            // BAjouter
            // 
            this.BAjouter.Location = new System.Drawing.Point(263, 297);
            this.BAjouter.Name = "BAjouter";
            this.BAjouter.Size = new System.Drawing.Size(163, 35);
            this.BAjouter.TabIndex = 19;
            this.BAjouter.Text = "Ajouter un produit";
            this.BAjouter.UseVisualStyleBackColor = true;
            this.BAjouter.Click += new System.EventHandler(this.BAjouter_Click);
            // 
            // BVider
            // 
            this.BVider.Location = new System.Drawing.Point(18, 297);
            this.BVider.Name = "BVider";
            this.BVider.Size = new System.Drawing.Size(163, 35);
            this.BVider.TabIndex = 20;
            this.BVider.Text = "Vider les champs";
            this.BVider.UseVisualStyleBackColor = true;
            this.BVider.Click += new System.EventHandler(this.BVider_Click);
            // 
            // ProduitAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(444, 354);
            this.Controls.Add(this.BVider);
            this.Controls.Add(this.BAjouter);
            this.Controls.Add(this.LbQuantite);
            this.Controls.Add(this.NQuantite);
            this.Controls.Add(this.DTDate);
            this.Controls.Add(this.LbDate);
            this.Controls.Add(this.LbPrixTTC);
            this.Controls.Add(this.NPrixTTC);
            this.Controls.Add(this.LbPrixHT);
            this.Controls.Add(this.NPrixHT);
            this.Controls.Add(this.TNom);
            this.Controls.Add(this.LbNom);
            this.Controls.Add(this.TCategorie);
            this.Controls.Add(this.LbCategorie);
            this.Controls.Add(this.TFournisseur);
            this.Controls.Add(this.LbFournisseur);
            this.Controls.Add(this.TRef);
            this.Controls.Add(this.LbRef);
            this.Controls.Add(this.LbAjouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProduitAjouter";
            this.Text = "Ajouter un produit";
            this.Load += new System.EventHandler(this.ProduitAjouter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NPrixHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPrixTTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbAjouter;
        private System.Windows.Forms.Label LbRef;
        private System.Windows.Forms.TextBox TRef;
        private System.Windows.Forms.TextBox TFournisseur;
        private System.Windows.Forms.Label LbFournisseur;
        private System.Windows.Forms.TextBox TCategorie;
        private System.Windows.Forms.Label LbCategorie;
        private System.Windows.Forms.TextBox TNom;
        private System.Windows.Forms.Label LbNom;
        private System.Windows.Forms.NumericUpDown NPrixHT;
        private System.Windows.Forms.Label LbPrixHT;
        private System.Windows.Forms.Label LbPrixTTC;
        private System.Windows.Forms.NumericUpDown NPrixTTC;
        private System.Windows.Forms.Label LbDate;
        private System.Windows.Forms.DateTimePicker DTDate;
        private System.Windows.Forms.NumericUpDown NQuantite;
        private System.Windows.Forms.Label LbQuantite;
        private System.Windows.Forms.Button BAjouter;
        private System.Windows.Forms.Button BVider;
    }
}