use master
go

alter database VILLAGEGREEN set restricted_user with rollback immediate
go

exec sp_dropdevice 'savVG'
go

exec sp_addumpdevice 'disk', 'savVG','C:\Backup\VGREEN.bak'
go

backup database VILLAGEGREEN to savVG
go

alter database VILLAGEGREEN set restricted_user with rollback immediate
go

DROP DATABASE VILLAGEGREEN
go

restore database VILLAGEGREEN from savVG with replace
go

alter database VILLAGEGREEN set multi_user
go