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
            this.ChampRef = new System.Windows.Forms.TextBox();
            this.ChampFournisseur = new System.Windows.Forms.TextBox();
            this.LbFournisseur = new System.Windows.Forms.Label();
            this.ChampCategorie = new System.Windows.Forms.TextBox();
            this.LbCategorie = new System.Windows.Forms.Label();
            this.ChampNom = new System.Windows.Forms.TextBox();
            this.LbNom = new System.Windows.Forms.Label();
            this.ChampPrixHT = new System.Windows.Forms.NumericUpDown();
            this.LbPrixHT = new System.Windows.Forms.Label();
            this.LbPrixTTC = new System.Windows.Forms.Label();
            this.ChampPrixTTC = new System.Windows.Forms.NumericUpDown();
            this.LbDate = new System.Windows.Forms.Label();
            this.ChampDate = new System.Windows.Forms.DateTimePicker();
            this.ChampQuantite = new System.Windows.Forms.NumericUpDown();
            this.LbQuantite = new System.Windows.Forms.Label();
            this.BAjouter = new System.Windows.Forms.Button();
            this.BVider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChampPrixHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChampPrixTTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChampQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // LbAjouter
            // 
            this.LbAjouter.AutoSize = true;
            this.LbAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAjouter.Location = new System.Drawing.Point(138, 36);
            this.LbAjouter.Name = "LbAjouter";
            this.LbAjouter.Size = new System.Drawing.Size(257, 32);
            this.LbAjouter.TabIndex = 0;
            this.LbAjouter.Text = "Ajouter un produit";
            // 
            // LbRef
            // 
            this.LbRef.AutoSize = true;
            this.LbRef.Location = new System.Drawing.Point(66, 102);
            this.LbRef.Name = "LbRef";
            this.LbRef.Size = new System.Drawing.Size(70, 16);
            this.LbRef.TabIndex = 1;
            this.LbRef.Text = "Référence";
            // 
            // ChampRef
            // 
            this.ChampRef.Location = new System.Drawing.Point(223, 99);
            this.ChampRef.Name = "ChampRef";
            this.ChampRef.Size = new System.Drawing.Size(254, 22);
            this.ChampRef.TabIndex = 0;
            // 
            // ChampFournisseur
            // 
            this.ChampFournisseur.Location = new System.Drawing.Point(223, 127);
            this.ChampFournisseur.Name = "ChampFournisseur";
            this.ChampFournisseur.Size = new System.Drawing.Size(254, 22);
            this.ChampFournisseur.TabIndex = 1;
            // 
            // LbFournisseur
            // 
            this.LbFournisseur.AutoSize = true;
            this.LbFournisseur.Location = new System.Drawing.Point(66, 130);
            this.LbFournisseur.Name = "LbFournisseur";
            this.LbFournisseur.Size = new System.Drawing.Size(77, 16);
            this.LbFournisseur.TabIndex = 3;
            this.LbFournisseur.Text = "Fournisseur";
            // 
            // ChampCategorie
            // 
            this.ChampCategorie.Location = new System.Drawing.Point(223, 155);
            this.ChampCategorie.Name = "ChampCategorie";
            this.ChampCategorie.Size = new System.Drawing.Size(254, 22);
            this.ChampCategorie.TabIndex = 2;
            // 
            // LbCategorie
            // 
            this.LbCategorie.AutoSize = true;
            this.LbCategorie.Location = new System.Drawing.Point(66, 158);
            this.LbCategorie.Name = "LbCategorie";
            this.LbCategorie.Size = new System.Drawing.Size(66, 16);
            this.LbCategorie.TabIndex = 5;
            this.LbCategorie.Text = "Catégorie";
            // 
            // ChampNom
            // 
            this.ChampNom.Location = new System.Drawing.Point(223, 183);
            this.ChampNom.Name = "ChampNom";
            this.ChampNom.Size = new System.Drawing.Size(254, 22);
            this.ChampNom.TabIndex = 3;
            // 
            // LbNom
            // 
            this.LbNom.AutoSize = true;
            this.LbNom.Location = new System.Drawing.Point(66, 186);
            this.LbNom.Name = "LbNom";
            this.LbNom.Size = new System.Drawing.Size(36, 16);
            this.LbNom.TabIndex = 7;
            this.LbNom.Text = "Nom";
            // 
            // ChampPrixHT
            // 
            this.ChampPrixHT.DecimalPlaces = 2;
            this.ChampPrixHT.Location = new System.Drawing.Point(223, 211);
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
            // LbPrixHT
            // 
            this.LbPrixHT.AutoSize = true;
            this.LbPrixHT.Location = new System.Drawing.Point(66, 213);
            this.LbPrixHT.Name = "LbPrixHT";
            this.LbPrixHT.Size = new System.Drawing.Size(48, 16);
            this.LbPrixHT.TabIndex = 10;
            this.LbPrixHT.Text = "PrixHT";
            // 
            // LbPrixTTC
            // 
            this.LbPrixTTC.AutoSize = true;
            this.LbPrixTTC.Location = new System.Drawing.Point(66, 241);
            this.LbPrixTTC.Name = "LbPrixTTC";
            this.LbPrixTTC.Size = new System.Drawing.Size(56, 16);
            this.LbPrixTTC.TabIndex = 12;
            this.LbPrixTTC.Text = "PrixTTC";
            // 
            // ChampPrixTTC
            // 
            this.ChampPrixTTC.DecimalPlaces = 2;
            this.ChampPrixTTC.Location = new System.Drawing.Point(223, 239);
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
            // LbDate
            // 
            this.LbDate.AutoSize = true;
            this.LbDate.Location = new System.Drawing.Point(66, 272);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(36, 16);
            this.LbDate.TabIndex = 13;
            this.LbDate.Text = "Date";
            // 
            // ChampDate
            // 
            this.ChampDate.Location = new System.Drawing.Point(223, 267);
            this.ChampDate.Name = "ChampDate";
            this.ChampDate.Size = new System.Drawing.Size(254, 22);
            this.ChampDate.TabIndex = 6;
            // 
            // ChampQuantite
            // 
            this.ChampQuantite.Location = new System.Drawing.Point(223, 295);
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
            // LbQuantite
            // 
            this.LbQuantite.AutoSize = true;
            this.LbQuantite.Location = new System.Drawing.Point(66, 297);
            this.LbQuantite.Name = "LbQuantite";
            this.LbQuantite.Size = new System.Drawing.Size(56, 16);
            this.LbQuantite.TabIndex = 16;
            this.LbQuantite.Text = "Quantité";
            // 
            // BAjouter
            // 
            this.BAjouter.Location = new System.Drawing.Point(314, 335);
            this.BAjouter.Name = "BAjouter";
            this.BAjouter.Size = new System.Drawing.Size(163, 35);
            this.BAjouter.TabIndex = 8;
            this.BAjouter.Text = "Ajouter un produit";
            this.BAjouter.UseVisualStyleBackColor = true;
            this.BAjouter.Click += new System.EventHandler(this.BAjouter_Click);
            // 
            // BVider
            // 
            this.BVider.Location = new System.Drawing.Point(69, 335);
            this.BVider.Name = "BVider";
            this.BVider.Size = new System.Drawing.Size(163, 35);
            this.BVider.TabIndex = 9;
            this.BVider.Text = "Vider les champs";
            this.BVider.UseVisualStyleBackColor = true;
            this.BVider.Click += new System.EventHandler(this.BVider_Click);
            // 
            // ProduitAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(547, 432);
            this.Controls.Add(this.BVider);
            this.Controls.Add(this.BAjouter);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "ProduitAjouter";
            this.Text = "Ajouter un produit";
            this.Load += new System.EventHandler(this.ProduitAjouter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProduitAjouter_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ChampPrixHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChampPrixTTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChampQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbAjouter;
        private System.Windows.Forms.Label LbRef;
        private System.Windows.Forms.TextBox ChampRef;
        private System.Windows.Forms.TextBox ChampFournisseur;
        private System.Windows.Forms.Label LbFournisseur;
        private System.Windows.Forms.TextBox ChampCategorie;
        private System.Windows.Forms.Label LbCategorie;
        private System.Windows.Forms.TextBox ChampNom;
        private System.Windows.Forms.Label LbNom;
        private System.Windows.Forms.NumericUpDown ChampPrixHT;
        private System.Windows.Forms.Label LbPrixHT;
        private System.Windows.Forms.Label LbPrixTTC;
        private System.Windows.Forms.NumericUpDown ChampPrixTTC;
        private System.Windows.Forms.Label LbDate;
        private System.Windows.Forms.DateTimePicker ChampDate;
        private System.Windows.Forms.NumericUpDown ChampQuantite;
        private System.Windows.Forms.Label LbQuantite;
        private System.Windows.Forms.Button BAjouter;
        private System.Windows.Forms.Button BVider;
    }
}