CREATE database WishList_T;
Go

Use WishList_T;
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
	idUsuario int Foreign Key references  Usuarios(idUsuario)
);
Go

DROP DATABASE WishList_T