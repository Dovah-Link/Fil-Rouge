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
    public partial class AjoutFourni : Form
    {
        SqlConnection con = new SqlConnection("server=.; database=VILLAGEGREEN; integrated security=true");

        public AjoutFourni()
        {
            InitializeComponent();
        }

        private void cb_ville_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AfficheCB()
        {
            con.Open();

            SqlCommand requete = new SqlCommand("SELECT NomVille FROM VILLE", con);

            SqlDataReader resultat = requete.ExecuteReader();

            while (resultat.Read())
            {
                FournisseurDAO database = new FournisseurDAO();
                cb_ville.DataSource = database;
                cb_ville.DataSource = database.List();

            }
            con.Close();

        }
    }
}
