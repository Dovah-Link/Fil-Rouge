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
            
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
    
}
