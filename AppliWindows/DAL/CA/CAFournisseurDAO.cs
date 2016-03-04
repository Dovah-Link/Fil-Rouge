using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CAFournisseurDAO
    {
        SqlConnection con = new SqlConnection("server=.; database=VILLAGEGREEN; integrated security=true");

        public double CA1Fournisseur(int IDFournisseur)
        {
            double ab = 0;
            con.Open();
            SqlCommand requete = new SqlCommand(@"SELECT    sum(L.PrixHTProduits*l.QuantiteCommandeProduits) 
                                                  FROM      FOURNI F
                                                  JOIN      PRODUITS p on p.IDProduits = F.IDProduits 
                                                  JOIN      LIGNE_DE_COMMANDE L on L.IDProduits = P.IDProduits 
                                                  JOIN      COMMANDE C on C.IDCommande = L.IDCommande 
                                                  WHERE     F.IDFournisseur = @p1", con);
            requete.Parameters.AddWithValue("@p1", IDFournisseur);
            SqlDataReader resultat = requete.ExecuteReader();

            if (resultat.Read())
            {
                if (resultat[0] != DBNull.Value)
                {
                    ab = Convert.ToDouble(resultat[0]);
                }
                else
                {
                    ab = 0;
                }
            }
            con.Close();
            return ab;
        }
        public double CATotFournisseur()
        {
            double ab = 0;
            con.Open();
            SqlCommand requete = new SqlCommand(@"SELECT    sum(L.PrixHTProduits*l.QuantiteCommandeProduits) 
                                                  FROM      FOURNI F
                                                  JOIN      PRODUITS p on p.IDProduits = F.IDProduits 
                                                  JOIN      LIGNE_DE_COMMANDE L on L.IDProduits = P.IDProduits 
                                                  JOIN      COMMANDE C on C.IDCommande = L.IDCommande", con);

            SqlDataReader resultat = requete.ExecuteReader();

            if (resultat.Read())
            {
                if (resultat[0] != DBNull.Value)
                {
                    ab = Convert.ToDouble(resultat[0]);
                }
                else
                {
                    ab = 0;
                }
            }
            con.Close();
            return ab;
        }
    }
}
