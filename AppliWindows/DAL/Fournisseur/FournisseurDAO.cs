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

            SqlCommand requete = new SqlCommand("select * from FOURNISSEUR F JOIN VILLE V on F.IDVille=V.IDVille ", con);

            SqlDataReader resultat = requete.ExecuteReader();

            while (resultat.Read())
            {
                Fournisseur fou = new Fournisseur();
                fou.Id = Convert.ToInt32(resultat["IDFournisseur"]);
                fou.Nom = Convert.ToString(resultat["NomFournisseur"]);
                fou.Mail = Convert.ToString(resultat["MailFournisseur"]);
                fou.Adresse = Convert.ToString(resultat["AdresseFournisseur"]);
                fou.IDVille = Convert.ToInt32(resultat["IDVille"]);
                fou.Ville = Convert.ToString(resultat["NomVille"]);
                liste.Add(fou);
            }
            con.Close();
            return liste;
        }
        public void Insert(Fournisseur f)
        {
            con.Open();
            SqlCommand requete = new SqlCommand("insert into FOURNISSEUR (NomFournisseur,AdresseFournisseur,MailFournisseur,IDVille) values (@p1,@p2,@p3,@p4)", con);
            requete.Parameters.AddWithValue("@p1", f.Nom);
            requete.Parameters.AddWithValue("@p2", f.Adresse);
            requete.Parameters.AddWithValue("@p3", f.Mail);
            requete.Parameters.AddWithValue("@p4", f.IDVille);


            requete.ExecuteNonQuery();
            con.Close();
        }
    }
}
