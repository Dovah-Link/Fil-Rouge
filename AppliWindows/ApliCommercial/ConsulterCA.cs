using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace ApliCommercial
{
    public partial class ConsulterCA : Form
    {
        public ConsulterCA()
        {
            InitializeComponent();
            MAJFournis();
        }
        private void ConsulterCA_Load(object sender, EventArgs e)
        {
            CAFournisseurDAO CAFDAO = new CAFournisseurDAO();

            double ab = CAFDAO.CATotFournisseur();
            lbl_catotres.Text = ab.ToString();
            lbl_catotres.Visible = true;
        }
        public void MAJFournis()
        {
            FournisseurDAO database = new FournisseurDAO();
            cb_fournis.SelectedIndex = -1;
            cb_fournis.DisplayMember = "Nom";
            cb_fournis.ValueMember = "Id";
            cb_fournis.DataSource = database.List();
        }

        public void cb_fournis_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cb_fournis.SelectedValue;

            CAFournisseurDAO CAFDAO = new CAFournisseurDAO();

            double ab = CAFDAO.CA1Fournisseur(id);
            lbl_caFourRes.Text = ab.ToString();
            lbl_caFourRes.Visible = true;
        }
    }
}
