CREATE TABLE [dbo].[Livros]
(
	[Id_Livro] INT IDENTITY(1, 1) PRIMARY KEY,
	Nome_Livro varchar(100) not null,
	Autor_Livro varchar(50) not null,
	Ano_Livro smallint not null,
	Genero_Livro varchar(50) not null,
	Editora_Livro varchar(50) not null,
	Paginas_Livro smallint null,
	Status_Livro char(1) not null
)
