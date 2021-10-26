CREATE database WishList;
Go

Use WishList;
Go

Create table Usuarios(
	idUsuario int primary Key identity,
	email varchar(256),
	senha varchar(20)
);
Go

Create table Desejos(
	idDesejo smallint primary key identity,
	descricao varchar(200),
	idUsuaio int Foreign Key references  Usuarios(idUsuario)
);
Go
