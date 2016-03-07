using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace ApliCommercial
{
    public partial class ConsulterFournisseur : Form
    {
        int id = 1;
        double ca,tot;
        public ConsulterFournisseur()
        {
            InitializeComponent();
        }

        private void ConsulterFournisseur_Load(object sender, EventArgs e)
        {
            FournisseurDAO fournisseur = new FournisseurDAO();
            List<Fournisseur> ListFournis = fournisseur.List();
          
            DGV.DataSource = ListFournis;
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DGV.RowHeadersVisible = false;
            DGV.Columns[0].Visible = false;
            DGV.Columns[4].Visible = false;

            //DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DGV.Columns["Nom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DGV.Columns["Adresse"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DGV.Columns["Mail"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DGV.Columns["Ville"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DGV.SelectionChanged += new System.EventHandler(this.DGV_SelectionChanged);

            CAFournisseurDAO CAFDAO = new CAFournisseurDAO();
            tot = CAFDAO.CATotFournisseur();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Le chiffre d'affaire généré grâce à ce fournisseur est de " +ca+" euros.\nLe chiffre d'affaire global est de "+tot+" euros","Chiffre d'affaire");
        }

        private void ConsulterFournisseur_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment quitter ?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form AjoutFourni = new AjoutFourni();
            AjoutFourni.ShowDialog(); 
        }

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
            id = Convert.ToInt32(DGV.SelectedRows[0].Cells[0].Value);
            CAFournisseurDAO CAFDAO = new CAFournisseurDAO();
            ca = CAFDAO.CA1Fournisseur(id);
        }
    }

}
