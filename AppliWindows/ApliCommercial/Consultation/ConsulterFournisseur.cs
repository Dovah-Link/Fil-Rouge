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
        public ConsulterFournisseur()
        {
            InitializeComponent();
        }

        private void ConsulterFournisseur_Load(object sender, EventArgs e)
        {
            FournisseurDAO fournisseur = new FournisseurDAO();
            List<Fournisseur> ListFournis = fournisseur.List();
            DGV.DataSource = ListFournis;

            DGV.RowHeadersVisible = false;
            DGV.Columns[0].Visible = false;
            DGV.Columns[4].Visible = false;

            //DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DGV.Columns["Nom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DGV.Columns["Adresse"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DGV.Columns["Mail"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DGV.Columns["Ville"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsulterCA CCA = new ConsulterCA();
            CCA.Show();
        }
    }
    
}
