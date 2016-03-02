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
using ApliCommercial;

namespace ApliCommercial
{
    public partial class AjoutFourni : Form
    {
        public AjoutFourni()
        {
            InitializeComponent();
        }
        private void AjoutFourni_Load(object sender, EventArgs e)
        {
            MAJVille();
            //cb_ville.SelectionStart
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajout.AjoutVille AJV = new Ajout.AjoutVille();
            AJV.ShowDialog();
            MAJVille();

        }
        public void MAJVille()
        {
            VilleDAO database = new VilleDAO();
            cb_ville.DisplayMember = "Nom";
            cb_ville.ValueMember = "Id";
            cb_ville.DataSource = database.List();
        }

        private void b_ajout_Click(object sender, EventArgs e)
        {
            try
            {
                Fournisseur f = new Fournisseur();
                f.Nom = tb_nom.Text;
                f.Adresse = tb_adresse.Text;
                f.Mail = tb_mail.Text;
                f.IDVille = (int)cb_ville.SelectedValue;

                FournisseurDAO data = new FournisseurDAO();

                data.Insert(f);
                MessageBox.Show("Ajout du fournisseur reussi", "Ajout d'un Fournisseur");

            }
            catch (Exception er)
            {
                MessageBox.Show("Une erreur est survenue !\n\n" + er);
            }
        }
    }
}
