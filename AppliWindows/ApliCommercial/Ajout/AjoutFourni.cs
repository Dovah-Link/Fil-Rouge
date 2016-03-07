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
using System.Text.RegularExpressions;

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
            bool a = NomValide(tb_nom.Text);
            bool b = MailValide(tb_mail.Text);
            bool c = AdresseValide(tb_adresse.Text);
            if (a == true && b == true && c == true)
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
            else
            {
                MessageBox.Show("Erreur de saisie de votre email\nVeuillez recommencez", "Erreur");
                tb_mail.Text = "";
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form CF = new ConsulterFournisseur();
            CF.Show();
        }

        /*---------------------------------------------------------------------------------------------------------- Test saisie couleur des tb au changements de valeurs*/

        public void tb_mail_TextChanged(object sender, EventArgs e)
        {
            bool a = MailValide(tb_mail.Text);
            if (a == true)
            {
                tb_mail.BackColor = Color.Green;
            }
            else
            {
                tb_mail.BackColor = Color.Red;
            }
        }
        private void tb_nom_TextChanged(object sender, EventArgs e)
        {
            bool a = NomValide(tb_nom.Text);
            if (a == true)
            {
                tb_nom.BackColor = Color.Green;
            }
            else
            {
                if(tb_nom.Text=="")
                {
                    tb_nom.BackColor = Color.White;
                }
                else
                {
                    tb_nom.BackColor = Color.Red;
                }
                
            }
        }
        private void tb_adresse_TextChanged(object sender, EventArgs e)
        {
            bool a = AdresseValide(tb_adresse.Text);
            if (a == true)
            {
                tb_adresse.BackColor = Color.Green;
            }
            else
            {
                if(tb_adresse.Text=="")
                {
                    tb_adresse.BackColor = Color.White;
                }
                else
                {
                    tb_adresse.BackColor = Color.Red;
                }
            }

        }
        /*-----------------------------------------------------------------TEST REGEX-------------------------------------------------------*/
        public static bool NomValide(string a)
        {
            bool b;
            if ((Regex.IsMatch(a, "^[A-Za-z0-9 ]{2,}(['.]{0,1}[A-Za-z0-9]{1,})*$") == true))
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }
        public static bool MailValide(string a)
        {
            bool b;
            if ((Regex.IsMatch(a, "^([a-zA-Z0-9]{1,}[._-]{0,1}[a-zA-Z0-9]{1,})+@([a-zA-Z0-9]{2,})[.]{1,}[a-zA-Z0-9]{2,}$") == true))
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }
        public static bool AdresseValide(string a)
        {
            bool b;
            if ((Regex.IsMatch(a, "^(([0-9]{1,5}[ ]{1,})?[A-Za-z0-9 ]+)$") == true))
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }

        private void b_annul_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous annuler votre saisie", "Annuler",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                tb_nom.Text = "";
                tb_adresse.Text = "";
                tb_mail.Text = "";
            }
        }

        private void AjoutFourni_FormClosing(object sender, FormClosingEventArgs e)
        {
           DialogResult result = MessageBox.Show("Voulez vous vraiment quitter ?", "", MessageBoxButtons.YesNo);
            if(result==DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
