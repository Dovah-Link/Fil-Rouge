namespace ApliCommercial
{
    partial class AjoutFourni
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.cb_ville = new System.Windows.Forms.ComboBox();
            this.b_ajout = new System.Windows.Forms.Button();
            this.b_annul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(215, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Espace Commercial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Corbel", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "VILLAGEGREEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(130, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(120, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(135, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ville";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(195, 190);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(195, 20);
            this.tb_nom.TabIndex = 10;
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(195, 288);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(195, 20);
            this.tb_adresse.TabIndex = 12;
            // 
            // cb_ville
            // 
            this.cb_ville.FormattingEnabled = true;
            this.cb_ville.Location = new System.Drawing.Point(195, 386);
            this.cb_ville.Name = "cb_ville";
            this.cb_ville.Size = new System.Drawing.Size(195, 21);
            this.cb_ville.TabIndex = 13;
            this.cb_ville.SelectedIndexChanged += new System.EventHandler(this.cb_ville_SelectedIndexChanged);
            // 
            // b_ajout
            // 
            this.b_ajout.Location = new System.Drawing.Point(345, 475);
            this.b_ajout.Name = "b_ajout";
            this.b_ajout.Size = new System.Drawing.Size(80, 26);
            this.b_ajout.TabIndex = 14;
            this.b_ajout.Text = "Ajouter";
            this.b_ajout.UseVisualStyleBackColor = true;
            // 
            // b_annul
            // 
            this.b_annul.Location = new System.Drawing.Point(447, 475);
            this.b_annul.Name = "b_annul";
            this.b_annul.Size = new System.Drawing.Size(80, 26);
            this.b_annul.TabIndex = 15;
            this.b_annul.Text = "Annuler";
            this.b_annul.UseVisualStyleBackColor = true;
            // 
            // AjoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(554, 526);
            this.Controls.Add(this.b_annul);
            this.Controls.Add(this.b_ajout);
            this.Controls.Add(this.cb_ville);
            this.Controls.Add(this.tb_adresse);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjoutClient";
            this.Text = "Ajouter Fournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.ComboBox cb_ville;
        private System.Windows.Forms.Button b_ajout;
        private System.Windows.Forms.Button b_annul;
    }
}