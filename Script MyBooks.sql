CREATE DATABASE LivrariaMyBooks; 
 GO
 use LivrariaMyBooks
 GO
 CREATE TABLE Livros (
     IdLivro varchar(255) PRIMARY KEY,
     Atuacao varchar(255),
     Titulo varchar(255), 
	 Autor varchar(255),
	 Editora varchar(255), 
	 Edicao int,
	 Volume int );
GO
use LivrariaMyBooks
GO
 CREATE TABLE Usuario (
     ID varchar(255) PRIMARY KEY,
     Logim varchar(255),
     Senha varchar(255),
	 Email varchar(255)
 );