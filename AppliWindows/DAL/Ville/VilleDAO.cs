using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DAL
{
    public class VilleDAO
    {
        SqlConnection con = new SqlConnection("server=.; database=VILLAGEGREEN; integrated security=true");

        public List<Ville> List()
        {
            List<Ville> liste = new List<Ville>();

            con.Open();

            SqlCommand requete = new SqlCommand("SELECT * FROM Ville order by nomville", con);

            SqlDataReader resultat = requete.ExecuteReader();

            while (resultat.Read())
            {
                Ville vi = new Ville();
                vi.Id = Convert.ToInt32(resultat["IDVille"]);
                vi.Nom = Convert.ToString(resultat["NomVille"]);
                liste.Add(vi);
            }
            con.Close();
            return liste;
        }
        public void Insert(Ville vi)
        {
            con.Open();

            SqlCommand requete = new SqlCommand("insert into VILLE (NomVille) values (@p1)", con);
            requete.Parameters.AddWithValue("@p1", vi.Nom);

            requete.ExecuteNonQuery();
            con.Close();
        }
    }
}
