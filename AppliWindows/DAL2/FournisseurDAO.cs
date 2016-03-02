using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FournisseurDAO
    {
        SqlConnection con = new SqlConnection("server=.; database=VILLAGEGREEN; integrated security=true");

        public List<Fournisseur> List()
        {
            List<Fournisseur> liste = new List<Fournisseur>();

            con.Open();

            SqlCommand requete = new SqlCommand("select * from client", con);

            SqlDataReader resultat = requete.ExecuteReader();

            while (resultat.Read())
            {
                Fournisseur fou = new Fournisseur();
                fou.Id = Convert.ToInt32(resultat["fou_id"]);
                fou.Nom = Convert.ToString(resultat["fou_nom"]);
                fou.IDVille = Convert.ToInt32(resultat["fou_villeID"]);

                liste.Add(fou);
            }
            con.Close();
            return liste;
        }
    }
}
