namespace ApliCommercial
{
    partial class ConsulterCA
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
            this.cb_fournis = new System.Windows.Forms.ComboBox();
            this.lbl_caFourRes = new System.Windows.Forms.Label();
            this.lbl_caFournisSelec = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_catotres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(246, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Espace Commercial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Corbel", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 78);
            this.label1.TabIndex = 8;
            this.label1.Text = "VILLAGEGREEN";
            // 
            // cb_fournis
            // 
            this.cb_fournis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_fournis.FormattingEnabled = true;
            this.cb_fournis.Location = new System.Drawing.Point(223, 142);
            this.cb_fournis.Name = "cb_fournis";
            this.cb_fournis.Size = new System.Drawing.Size(181, 21);
            this.cb_fournis.TabIndex = 10;
            this.cb_fournis.SelectedIndexChanged += new System.EventHandler(this.cb_fournis_SelectedIndexChanged);
            // 
            // lbl_caFourRes
            // 
            this.lbl_caFourRes.AutoSize = true;
            this.lbl_caFourRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caFourRes.Location = new System.Drawing.Point(279, 255);
            this.lbl_caFourRes.Name = "lbl_caFourRes";
            this.lbl_caFourRes.Size = new System.Drawing.Size(51, 16);
            this.lbl_caFourRes.TabIndex = 11;
            this.lbl_caFourRes.Text = "label3";
            this.lbl_caFourRes.Visible = false;
            // 
            // lbl_caFournisSelec
            // 
            this.lbl_caFournisSelec.AutoSize = true;
            this.lbl_caFournisSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caFournisSelec.Location = new System.Drawing.Point(176, 204);
            this.lbl_caFournisSelec.Name = "lbl_caFournisSelec";
            this.lbl_caFournisSelec.Size = new System.Drawing.Size(257, 18);
            this.lbl_caFournisSelec.TabIndex = 12;
            this.lbl_caFournisSelec.Text = "Chiffre d\'affaire par fournisseur : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Chiffre d\'affaire total : ";
            // 
            // lbl_catotres
            // 
            this.lbl_catotres.AutoSize = true;
            this.lbl_catotres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_catotres.Location = new System.Drawing.Point(279, 360);
            this.lbl_catotres.Name = "lbl_catotres";
            this.lbl_catotres.Size = new System.Drawing.Size(51, 16);
            this.lbl_catotres.TabIndex = 14;
            this.lbl_catotres.Text = "label3";
            this.lbl_catotres.Visible = false;
            // 
            // ConsulterCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(636, 454);
            this.Controls.Add(this.lbl_catotres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_caFournisSelec);
            this.Controls.Add(this.lbl_caFourRes);
            this.Controls.Add(this.cb_fournis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ConsulterCA";
            this.Text = "ConsulterCA";
            this.Load += new System.EventHandler(this.ConsulterCA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_fournis;
        private System.Windows.Forms.Label lbl_caFourRes;
        private System.Windows.Forms.Label lbl_caFournisSelec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_catotres;
    }
}