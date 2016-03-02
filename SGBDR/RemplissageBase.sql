-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------			/*				REMPLISSAGE BASE				*/			-------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

use VILLAGEGREEN
go

SET IDENTITY_INSERT RUBRIQUE on
go



INSERT into RUBRIQUE(IDRubrique, LibelleRubrique)
VALUES 
	(1, 'Guitares'),
	(2, 'Basses'),
	(3, 'Batteries'),
	(4, 'Pianos'),
	(5, 'DJ'),
	(6,'Instr. Vent'),
	(7,'Accessoires')
go

SET IDENTITY_INSERT RUBRIQUE off
go

SET IDENTITY_INSERT SOUSRUBRIQUE on
go

INSERT into SOUSRUBRIQUE(IDSousRubrique, LibelleSousRubrique,IDRubrique)
VALUES
	(1,'Guitares Electriques',1),
	(2,'Guitares Acoustiques',1),
	(3,'Basses Electriques',2),
	(4,'Basses Acoustiques',2),
	(5,'Batteries Electroniques',3),
	(6,'Batteries Acoustiques',3),
	(7,'Pianos Droits',4),
	(8,'Pianos à queue',4),
	(9,'Platines',5),
	(10,'Contrôleurs',5),
	(11,'Bois',6),
	(12,'Cuivre',6),
	(13,'Cordes',7),
	(14,'Casques Audios',7)
go

SET IDENTITY_INSERT SOUSRUBRIQUE off
go

SET IDENTITY_INSERT PRODUITS on
go

INSERT into PRODUITS(IDProduits, NomProduits, MarquesProduits, QuantiteStockProduits,IDSousRubrique)
VALUES
	(1,'SG Standard 2016 EB Ebony','Gibson',10,1),
	(2,'C40BL NOIRE','YAMAHA',20,2),
	(3,'SR 300 IPT Iron Pewter','Ibanez',3,3),
	(4,'ABG-5C Naturel','Jack & Danny',2,4),
	(5,'DTX400K','YAMAHA',2,5),
	(6,'Set complet Tornado Studio TNM5044Z','Fame',3,6),
	(7,'B1 PE Piano 109 cm noir poli','YAMAHA',4,7),
	(8,'Grand Model 185 Black polished','Bösendorf',1,8),
	(9,'PT01 USB Tourne-disque portable USB','Numark',14,9),
	(10,'TRAKTOR Kontrol S8 Flagship système DJ tout en un','Native Instrument',7,10),
	(11,'Premium Bamboo Pan Flute C 700.255','Gewa',10,11),
	(12,'YBB-105 Tuba Si Bémol','YAMAHA',6,12),
	(13,'DR BKE-11 11-50 Black Beauties Extra Life','DR',58,13),
	(14,'HPS 5000 Casque Studio fermé 20 Hz - 20 kHz','Behringer',50,14)
go

SET IDENTITY_INSERT PRODUITS off
go

SET IDENTITY_INSERT VILLE on
go

INSERT into VILLE(IDVille,NomVille)
VALUES
	(1,'Talmas'),
	(2,'Paris'),
	(3,'Lille'),
	(4,'Rome'),
	(5,'Konoha'),
	(6,'Jadielle')
go

SET IDENTITY_INSERT VILLE off
go

SET IDENTITY_INSERT FOURNISSEUR on
go

INSERT into FOURNISSEUR(IDFournisseur, NomFournisseur, AdresseFournisseur, IDVille)
VALUES
	(1,'Momo la recup','68 rue du lama',1),
	(2,'Heisenberg','69 rue de la debauche',2),
	(3,'Dany Boon','59 rue deul baraque à frites',3),
	(4,'Julio Iglesias','125 boulevard des 126 dents',4),
	(5,'Naruto Uzumaki','3 chemin des Hokage',5),
	(6,'Giovanni','Arène pokemon',6)
go

SET IDENTITY_INSERT FOURNISSEUR off
go


INSERT into FOURNI(PrixAchatUnitaire, QuantiteFournisseur, IDFournisseur, IDProduits)
VALUES
	(150.50,4,1,1),
	(300000.99,100,2,2),
	(2,2,6,3)
go

SET IDENTITY_INSERT COMMERCIAL ON
go

INSERT into COMMERCIAL(IDCommercial,NomCommercial,PrenomCommercial)
VALUES
	(1,'Sebastien','Patrick'),
	(2,'Halliday','Johnny'),
	(3,'Young','Angus')

SET IDENTITY_INSERT COMMERCIAL off
go

SET IDENTITY_INSERT CLIENTS on
go

INSERT into CLIENTS(IDClients, NomClients, AdresseLivraisonClients, TypesClients,IDVille,IDCommercial)
VALUES
	(1,'Albus Perceval Wulfric Brian DUMBLEDOR','7 chemin de travers',0,1,1),
	(2,'Mimi Mathy','1 ruelle des 7 nains',1,2,1),
	(3,'Michel Michel','3 boulevard de la campagne',0,3,3),
	(4,'Jacky Jacky','3 bis boulevard de la campagne',1,3,2)
go

SET IDENTITY_INSERT CLIENTS off
go

SET IDENTITY_INSERT FACTURE on
go

INSERT into FACTURE(IDFacture, DateMaxReglement, DateReglement, PrixTotal)
VALUES
	(1,'15/12/2015','13/12/2015',100),
	(2,'16/12/2015',null,200),
	(3,'17/12/2015','21/10/2015',300),
	(4,'09/09/2016','21/10/2015',200)
go

SET IDENTITY_INSERT FACTURE off
go

INSERT into REDUCTION(Remise, IDCommercial, IDFacture)
VALUES
	(15,1,1),
	(20,1,2),
	(30,2,1),
	(40,2,2)
go

SET IDENTITY_INSERT COMMANDE on
go

INSERT into COMMANDE(IDCommande, EtatCommande, DateCommande, TotalHTCommande,TotalTVA,TotalTTC,IDClients,EtatReglement,IDFacture)
VALUES
	(1, 0, '21/10/2015', 300.50,20,320.50,1,1,1),
	(2, 1, '09/04/2015', 50.50,20,70.50,2,0,2)
go

SET IDENTITY_INSERT COMMANDE off
go

SET IDENTITY_INSERT LIGNE_DE_COMMANDE on
go

INSERT into LIGNE_DE_COMMANDE(IDLdC,QuantiteCommandeProduits,PrixHTProduits,TotalHTLdC,TauxTVA,TotalTTCLdC,IDProduits,IDCommande)
VALUES
	(1,1,300.50,300.50,20,320.50,1,1),
	(2,1,50.50,50.50,20,70.50,2,2)
go

SET IDENTITY_INSERT LIGNE_DE_COMMANDE off
go

SET IDENTITY_INSERT LIVRAISON on
go

INSERT into LIVRAISON(IDLivraison,DateLivraison,EtatLivraison,BonLivraison,IDCommande)
VALUES
	(1,'21/10/2050','en cours','Bonsouair',1),
	(2,'10/04/2015','livré','Bonsouair',2)

go

SET IDENTITY_INSERT LIVRAISON off
go

INSERT into EXPEDIER(QuantiteExpedier,IDProduits,IDLivraison)
VALUES
	(1,1,1),
	(1,2,2)

go

use master
go

