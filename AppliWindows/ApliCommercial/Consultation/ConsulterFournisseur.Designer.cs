namespace ApliCommercial
{
    partial class ConsulterFournisseur
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.lbl_consultca = new System.Windows.Forms.LinkLabel();
            this.lbl_ajoutfournis = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(184, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Espace Commercial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Corbel", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 78);
            this.label1.TabIndex = 6;
            this.label1.Text = "VILLAGEGREEN";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(48, 129);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(381, 224);
            this.DGV.TabIndex = 8;
            // 
            // lbl_consultca
            // 
            this.lbl_consultca.AutoSize = true;
            this.lbl_consultca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_consultca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_consultca.LinkColor = System.Drawing.Color.RosyBrown;
            this.lbl_consultca.Location = new System.Drawing.Point(403, 89);
            this.lbl_consultca.Name = "lbl_consultca";
            this.lbl_consultca.Size = new System.Drawing.Size(68, 13);
            this.lbl_consultca.TabIndex = 20;
            this.lbl_consultca.TabStop = true;
            this.lbl_consultca.Text = "Consulter CA";
            this.lbl_consultca.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbl_ajoutfournis
            // 
            this.lbl_ajoutfournis.AutoSize = true;
            this.lbl_ajoutfournis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajoutfournis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_ajoutfournis.LinkColor = System.Drawing.Color.RosyBrown;
            this.lbl_ajoutfournis.Location = new System.Drawing.Point(22, 89);
            this.lbl_ajoutfournis.Name = "lbl_ajoutfournis";
            this.lbl_ajoutfournis.Size = new System.Drawing.Size(97, 13);
            this.lbl_ajoutfournis.TabIndex = 21;
            this.lbl_ajoutfournis.TabStop = true;
            this.lbl_ajoutfournis.Text = "Ajouter Fournisseur";
            this.lbl_ajoutfournis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ConsulterFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(498, 415);
            this.Controls.Add(this.lbl_ajoutfournis);
            this.Controls.Add(this.lbl_consultca);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsulterFournisseur";
            this.Text = "Consulter Fournisseur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsulterFournisseur_FormClosing);
            this.Load += new System.EventHandler(this.ConsulterFournisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.LinkLabel lbl_consultca;
        private System.Windows.Forms.LinkLabel lbl_ajoutfournis;
    }
}