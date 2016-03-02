
--CA des Fournisseur
SELECT		F.NomFournisseur,sum(PrixAchatUnitaire*QuantiteFournisseur) as 'CA par Fournisseur'
FROM		FOURNI as FO
JOIN		FOURNISSEUR as F on F.IDFournisseur=FO.IDFournisseur
GROUP BY	F.NomFournisseur

--CA des commandes
SELECT		sum(PrixTotal) as 'CA Total des commandes'
FROM		FACTURE as F

--Total produits commandés
SELECT		LDC.IDProduits, P.NomProduits, LDC.QuantiteCommandeProduits
FROM		PRODUITS as P
JOIN		LIGNE_DE_COMMANDE as LDC on LDC.IDProduits=P.IDProduits

--Commandes par clients
SELECT		CO.IDClients,C.NomClients,CO.IDCommande,CO.DateCommande,F.PrixTotal as 'Prix Total de la commande'
FROM		CLIENTS as C
JOIN		COMMANDE as CO on CO.IDClients=C.IDClients
JOIN		FACTURE as F on CO.IDFacture=F.IDFacture
--WHERE		NomClients='Mimi Mathy'

--CA par types de clients=1
SELECT		C.NomClients,C.TypesClients,sum(PrixTotal) as 'CA pour Types Clients=1'
FROM		FACTURE as FA
JOIN		COMMANDE AS CO on FA.IDFacture=CO.IDFacture
JOIN		CLIENTS as C on C.IDClients=CO.IDClients
WHERE		C.TypesClients=1
GROUP BY	C.NomClients, C.TypesClients

--CA par types clients=0
SELECT		C.NomClients,C.TypesClients,sum(PrixTotal) as 'CA pour Types Clients=0'
FROM		FACTURE as FA
JOIN		COMMANDE AS CO on FA.IDFacture=CO.IDFacture
JOIN		CLIENTS as C on C.IDClients=CO.IDClients
WHERE		C.TypesClients=0
GROUP BY	C.NomClients, C.TypesClients

SELECT		* 
FROM		COMMANDE as C
JOIN		LIVRAISON as L on L.IDCommande=C.IDClients
WHERE		EtatLivraison='en cours'

go
------ Vue Produits-Fournisseurs

CREATE VIEW Joint_Produit_Fournisseur
as

SELECT		P.*, FO.*, F.PrixAchatUnitaire,F.QuantiteFournisseur
FROM		PRODUITS as P
JOIN		FOURNI as F on P.IDProduits=F.IDProduits
JOIN		FOURNISSEUR as FO on F.IDFournisseur=FO.IDFournisseur
go

SELECT		* 
FROM		Joint_Produit_Fournisseur
go