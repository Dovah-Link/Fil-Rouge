-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------			/*				CREATION VILLAGEGREEN				*/			---------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

use master
go

DROP DATABASE	VILLAGEGREEN
go

CREATE DATABASE VILLAGEGREEN
go

use VILLAGEGREEN
go

/*------------------------------------------------------------
 Table: RUBRIQUE
------------------------------------------------------------*/

CREATE TABLE RUBRIQUE
(
        IDRubrique				int IDENTITY PRIMARY KEY  NOT NULL ,
        LibelleRubrique			varchar (100) ,
)

/*------------------------------------------------------------
 Table: SOUSRUBRIQUE
------------------------------------------------------------*/

CREATE TABLE SOUSRUBRIQUE
(
        IDSousRubrique			int IDENTITY PRIMARY KEY NOT NULL ,
        LibelleSousRubrique		varchar (50) NOT NULL ,
		IDRubrique				int REFERENCES RUBRIQUE(IDRubrique)

)

/*------------------------------------------------------------
 Table: PRODUITS
------------------------------------------------------------*/

CREATE TABLE PRODUITS
(
        IDProduits				int IDENTITY  NOT NULL PRIMARY KEY,
        NomProduits				varchar (100) NOT NULL ,
        MarquesProduits			varchar (50) NOT NULL ,
        QuantiteStockProduits	int,
        ImageProduit			varchar (200),
		IDSousRubrique			int REFERENCES SOUSRUBRIQUE(IDSousRubrique)
)

CREATE INDEX  IDXNomProduits  ON PRODUITS(NomProduits)
go

/*------------------------------------------------------------
 Table: VILLE
------------------------------------------------------------*/

CREATE TABLE VILLE
(
        IDVille					int IDENTITY PRIMARY KEY  NOT NULL ,
        NomVille				varchar (200) NOT NULL ,
)

/*------------------------------------------------------------
 Table: FOURNISSEUR
------------------------------------------------------------*/

CREATE TABLE FOURNISSEUR
(
        IDFournisseur			int IDENTITY PRIMARY KEY  NOT NULL ,
        NomFournisseur			varchar (100) ,
        AdresseFournisseur		varchar (300) NOT NULL ,
        IDVille					int REFERENCES VILLE(IDVille)
)

CREATE INDEX  IDXNomFournisseur  ON FOURNISSEUR(NomFournisseur)
go

/*------------------------------------------------------------
 Table: FOURNI
------------------------------------------------------------*/

CREATE TABLE FOURNI
(
        PrixAchatUnitaire		decimal (15,3)  NOT NULL ,
        QuantiteFournisseur		int ,
		IDFournisseur			int REFERENCES FOURNISSEUR(IDFournisseur),
		IDProduits				int REFERENCES PRODUITS(IDProduits),
        PRIMARY KEY (IDFournisseur ,IDProduits )
)


/*------------------------------------------------------------
 Table: COMMERCIAL
------------------------------------------------------------*/

CREATE TABLE COMMERCIAL
(
        IDCommercial			int IDENTITY PRIMARY KEY NOT NULL ,
        NomCommercial			varchar (100) NOT NULL ,
        PrenomCommercial		varchar (100) NOT NULL
)

CREATE INDEX  IDXNomCommercial  ON COMMERCIAL(NomCommercial)
go

/*------------------------------------------------------------
 Table: CLIENTS
------------------------------------------------------------*/

CREATE TABLE CLIENTS
(
        IDClients               int IDENTITY PRIMARY KEY  NOT NULL ,
        NomClients              varchar (100) NOT NULL ,
        AdresseLivraisonClients varchar (200) NOT NULL ,
        TypesClients            bit ,
		IDVille					int REFERENCES VILLE(IDVille),
		IDCommercial			int REFERENCES COMMERCIAL(IDCommercial)
)

CREATE INDEX  IDXNomClients  ON CLIENTS(NomClients)
go

/*------------------------------------------------------------
 Table: FACTURE
------------------------------------------------------------*/

CREATE TABLE FACTURE
(
        IDFacture				int IDENTITY PRIMARY KEY  NOT NULL ,
        DateMaxReglement		date ,
        DateReglement			date null,
        PrixTotal				decimal (15,3)  NOT NULL ,
)

/*------------------------------------------------------------
 Table: REDUCTION
------------------------------------------------------------*/

CREATE TABLE REDUCTION
(
        Remise					numeric NOT NULL ,
		IDCommercial			int REFERENCES COMMERCIAL(IDCommercial),
		IDFacture				int REFERENCES FACTURE(IDFacture),
        PRIMARY KEY (IDCommercial ,IDFacture)
)



/*------------------------------------------------------------
 Table: COMMANDE
------------------------------------------------------------*/

CREATE TABLE COMMANDE
(
        IDCommande				int IDENTITY  NOT NULL ,
        EtatCommande			bit NOT NULL ,
        DateCommande			date NOT NULL ,
        TotalHTCommande			decimal (15,3)  NOT NULL ,
        TotalTVA				numeric NOT NULL ,
        TotalTTC				decimal (15,3)  NOT NULL ,
        EtatReglement			bit NOT NULL ,
		IDClients				int REFERENCES CLIENTS(IDClients),
		IDFacture				int REFERENCES FACTURE(IDFacture),
		PRIMARY KEY (IDCommande )

)

/*------------------------------------------------------------
 Table: LIGNE DE COMMANDE
------------------------------------------------------------*/

CREATE TABLE LIGNE_DE_COMMANDE
(
        IDLdC                    int IDENTITY PRIMARY KEY  NOT NULL ,
        QuantiteCommandeProduits int NOT NULL ,
        PrixHTProduits           decimal (15,3)  NOT NULL ,
        TotalHTLdC               decimal (15,3)  ,
        TauxTVA                  numeric NOT NULL ,
        TotalTTCLdC              decimal (15,3)  NOT NULL ,
		IDProduits				 int REFERENCES PRODUITS(IDProduits),
		IDCommande				 int REFERENCES COMMANDE(IDCommande)
)

/*------------------------------------------------------------
 Table: LIVRAISON
------------------------------------------------------------*/

CREATE TABLE LIVRAISON
(
        IDLivraison				 int IDENTITY PRIMARY KEY NOT NULL ,
        DateLivraison			 date ,
        EtatLivraison			 varchar (25) ,
        BonLivraison			 varchar (2000) NOT NULL ,
		IDCommande				 int REFERENCES COMMANDE(IDCommande)
)

/*------------------------------------------------------------
 Table: EXPEDIER
------------------------------------------------------------*/

CREATE TABLE EXPEDIER
(
        QuantiteExpedier		 int NOT NULL ,
		IDProduits				 int REFERENCES PRODUITS(IDProduits),
		IDLivraison				 int REFERENCES LIVRAISON(IDLivraison),
        PRIMARY KEY (IDProduits ,IDLivraison )
)

use master
go