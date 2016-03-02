-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------			/*				SECURITE ET ROLE				*/			-------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


-----------------------------CREATE LOGIN-------------------------------------------------------------------------------------------
use master
go

CREATE LOGIN administrateurVG with PASSWORD ='pwd', DEFAULT_DATABASE=[VILLAGEGREEN],
CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
go

CREATE LOGIN clientVG with PASSWORD ='pwd', DEFAULT_DATABASE=[VILLAGEGREEN],
CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
go

CREATE LOGIN commercialVG with PASSWORD ='pwd', DEFAULT_DATABASE=[VILLAGEGREEN],
CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
go



---------------------------- CLIENT -----------------------------------------------------------------------------------------
use VILLAGEGREEN
go

CREATE USER ADMIN1 for LOGIN administrateurVG
go

EXECUTE sp_addrolemember 'db_owner','ADMIN1'
go

CREATE USER CLIENT1 for LOGIN clientVG
go

CREATE role VGViewerClient
go

CREATE USER COMMERCIAL1 for LOGIN commercialVG
go

-----------------------------------------------------------------------------------------------------------------------------

use VILLAGEGREEN
go

GRANT SELECT on PRODUITS to VGViewerClient
go

GRANT SELECT on SOUSRUBRIQUE to VGViewerClient
go

GRANT SELECT on RUBRIQUE to VGViewerClient
go

GRANT SELECT on FACTURE to VGViewerClient
go

GRANT SELECT on COMMANDE to VGViewerClient
go

GRANT SELECT on LIVRAISON to VGViewerClient
go

-----------------------------------------------------------------------------------------------------------------------------

DENY DELETE on CLIENTS to VGViewerClient
go

DENY DELETE on COMMANDE to VGViewerClient
go

DENY DELETE on COMMERCIAL to VGViewerClient
go

DENY DELETE on EXPEDIER to VGViewerClient
go

DENY DELETE on FACTURE to VGViewerClient
go

DENY DELETE on FOURNI to VGViewerClient
go

DENY DELETE on FOURNISSEUR to VGViewerClient
go

DENY DELETE on LIGNE_DE_COMMANDE to VGViewerClient
go

DENY DELETE on LIVRAISON to VGViewerClient
go

DENY DELETE on PRODUITS to VGViewerClient
go

DENY DELETE on REDUCTION to VGViewerClient
go

DENY DELETE on RUBRIQUE to VGViewerClient
go

DENY DELETE on SOUSRUBRIQUE to VGViewerClient
go

DENY DELETE on VILLE to VGViewerClient
go

------------------------------------------------------------------------------------------------------------------------------------

GRANT UPDATE on CLIENTS to VGViewerClient
go

DENY UPDATE on COMMANDE to VGViewerClient
go

DENY UPDATE on COMMERCIAL to VGViewerClient
go

DENY UPDATE on EXPEDIER to VGViewerClient
go

DENY UPDATE on FACTURE to VGViewerClient
go

DENY UPDATE on FOURNI to VGViewerClient
go

DENY UPDATE on FOURNISSEUR to VGViewerClient
go

DENY UPDATE on LIGNE_DE_COMMANDE to VGViewerClient
go

DENY UPDATE on LIVRAISON to VGViewerClient
go

DENY UPDATE on PRODUITS to VGViewerClient
go

DENY UPDATE on REDUCTION to VGViewerClient
go

DENY UPDATE on RUBRIQUE to VGViewerClient
go

DENY UPDATE on SOUSRUBRIQUE to VGViewerClient
go

DENY UPDATE on VILLE to VGViewerClient
go

-----------------------------------------------------------------------------------------------------------------------------------

DENY INSERT on CLIENTS to VGViewerClient
go

DENY INSERT on COMMANDE to VGViewerClient
go

DENY INSERT on COMMERCIAL to VGViewerClient
go

DENY INSERT on EXPEDIER to VGViewerClient
go

DENY INSERT on FACTURE to VGViewerClient
go

DENY INSERT on FOURNI to VGViewerClient
go

DENY INSERT on FOURNISSEUR to VGViewerClient
go

DENY INSERT on LIGNE_DE_COMMANDE to VGViewerClient
go

DENY INSERT on LIVRAISON to VGViewerClient
go

DENY INSERT on PRODUITS to VGViewerClient
go

DENY INSERT on REDUCTION to VGViewerClient
go

DENY INSERT on RUBRIQUE to VGViewerClient
go

DENY INSERT on SOUSRUBRIQUE to VGViewerClient
go

DENY INSERT on VILLE to VGViewerClient
go

----------------------------- COMMERCIAL ------------------------------------------------------------------------------------------

GRANT SELECT on CLIENTS to COMMERCIAL1
go

GRANT SELECT on COMMANDE to COMMERCIAL1
go

GRANT SELECT on COMMERCIAL to COMMERCIAL1
go

GRANT SELECT on EXPEDIER to COMMERCIAL1
go

GRANT SELECT on FACTURE to COMMERCIAL1
go

GRANT SELECT on FOURNI to COMMERCIAL1
go

GRANT SELECT on FOURNISSEUR to COMMERCIAL1
go

GRANT SELECT on LIGNE_DE_COMMANDE to COMMERCIAL1
go

GRANT SELECT on LIVRAISON to COMMERCIAL1
go

GRANT SELECT on PRODUITS to COMMERCIAL1
go

GRANT SELECT on REDUCTION to COMMERCIAL1
go

GRANT SELECT on RUBRIQUE to COMMERCIAL1
go

GRANT SELECT on SOUSRUBRIQUE to COMMERCIAL1
go

GRANT SELECT on VILLE to COMMERCIAL1
go

--------------------------------------------------------------------------------------------------------

GRANT INSERT on REDUCTION to COMMERCIAL1
go

GRANT INSERT on CLIENTS to COMMERCIAL1
go

GRANT INSERT on COMMANDE to COMMERCIAL1
go

GRANT INSERT on FACTURE to COMMERCIAL1
go

GRANT INSERT on LIVRAISON to COMMERCIAL1
go

GRANT INSERT on EXPEDIER to COMMERCIAL1
go

GRANT INSERT on FOURNISSEUR to COMMERCIAL1
go

GRANT INSERT on FOURNI to COMMERCIAL1
go

GRANT INSERT on FOURNI to COMMERCIAL1
go

----------------------------------------------------------------------------------------------------------

GRANT UPDATE on REDUCTION to COMMERCIAL1
go

GRANT UPDATE on CLIENTS to COMMERCIAL1
go

GRANT UPDATE on COMMANDE to COMMERCIAL1
go

GRANT UPDATE on FACTURE to COMMERCIAL1
go

GRANT UPDATE on LIVRAISON to COMMERCIAL1
go

GRANT UPDATE on EXPEDIER to COMMERCIAL1
go

GRANT UPDATE on FOURNISSEUR to COMMERCIAL1
go

GRANT UPDATE on FOURNI to COMMERCIAL1
go

GRANT UPDATE on LIGNE_DE_COMMANDE to COMMERCIAL1
go
---------------------------------------------------------------------------------------------------------

DENY INSERT on COMMERCIAL to COMMERCIAL1
go

DENY INSERT on PRODUITS to COMMERCIAL1
go

DENY INSERT on RUBRIQUE to COMMERCIAL1
go

DENY INSERT on SOUSRUBRIQUE to COMMERCIAL1
go

DENY INSERT on VILLE to COMMERCIAL1
go

----------------------------------------------------------------------------------------------------------

DENY UPDATE on COMMERCIAL to COMMERCIAL1
go

DENY UPDATE on PRODUITS to COMMERCIAL1
go

DENY UPDATE on RUBRIQUE to COMMERCIAL1
go

DENY UPDATE on SOUSRUBRIQUE to COMMERCIAL1
go

DENY UPDATE on VILLE to COMMERCIAL1
go

--------------------------------------------------------------------------------------------------------------

use master
go