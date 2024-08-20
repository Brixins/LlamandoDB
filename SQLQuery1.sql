create table Persona (
id nvarchar (150) not null primary key,
Nombres nvarchar (150) not null,
Apellidos nvarchar (150) not null,
Telefono varchar (12),
FechaNacimiento varchar (8)
)
go
select * from Cuenta
select * from Persona


SELECT TOP (1000) [ID]
		,[Nombres]
		,[Apellidos]
		,[Telefono]
		,[FechaNacimiento]
	FROM [ConociendoSQL].[dbo].[Persona]
