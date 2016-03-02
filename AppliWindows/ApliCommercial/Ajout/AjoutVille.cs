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

namespace ApliCommercial.Ajout
{
    public partial class AjoutVille : Form
    {
        SqlConnection con = new SqlConnection("server=.; database=VILLAGEGREEN; integrated security=true");

        public AjoutVille()
        {
            InitializeComponent();
        }

        public void B_ok_Click(object sender, EventArgs e)
        {
            try
            {
                Ville c = new Ville();
                c.Nom = tb_nom.Text;
                VilleDAO database = new VilleDAO();
                database.Insert(c);
                MessageBox.Show("Ajout de la ville réussi !", "Ajout");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Un problème est survenue, vérifier votre saisie", "Erreur");
            }
        }
    }
}
