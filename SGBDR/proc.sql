----------------------------------- proc stockees

----procedure afficher les commandes en cours de livraison

CREATE PROC Com_non_sold
as
SELECT		* 
FROM		COMMANDE as C
JOIN		LIVRAISON as L on L.IDCommande=C.IDClients
WHERE		EtatLivraison='en cours'

EXEC		Com_non_sold
go

----procedure delai moyen

CREATE PROC Delai_moyen
as
SELECT		AVG(convert(int,day(DateLivraison))-convert(int,day(DateReglement))) as 'Temps moyen livraison en jours'
FROM		FACTURE as F
JOIN		COMMANDE as C on C.IDFacture=F.IDFacture
JOIN		LIVRAISON as L on L.IDCommande=C.IDCommande

EXEC Delai_moyen
go