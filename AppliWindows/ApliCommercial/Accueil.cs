using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApliCommercial
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AjoutCommande CC = new AjoutCommande();
            CC.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AjoutProduit AP = new AjoutProduit();
            AP.Show();
        }
    }
}
