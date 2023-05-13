DROP TABLE tbl_ebooks;
CREATE TABLE tbl_ebooks (
	Id INT IDENTITY(1, 1) NOT NULL,
	Name VARCHAR(80) NOT NULL,
	Descricao varchar(140),
	Downloads INT NOT NULL);

CREATE CLUSTERED INDEX id ON tbl_ebooks (id);
INSERT INTO tbl_ebooks (Name, Downloads) VALUES ('OneNote', 5); 

DROP TABLE tbl_email;
CREATE TABLE tbl_email (
	Id INT IDENTITY(1, 1) NOT NULL,
	IdLista INT NOT NULL,
	Mail VARCHAR(80) NOT NULL,
	Data DATETIME NOT NULL);

CREATE CLUSTERED INDEX id ON tbl_email (id);

DROP TABLE tbl_enviados;
CREATE TABLE tbl_enviados (
	Id INT IDENTITY(1, 1) NOT NULL,
	Nome varchar(80) NOT NULL,
	Descricao varchar(140),
	Conteudo VARCHAR(max) NOT NULL,
	Enviado DATETIME NOT NULL);

CREATE CLUSTERED INDEX id ON tbl_enviados (id);

DROP TABLE tbl_lista;
CREATE TABLE tbl_lista (
	Id INT IDENTITY(1, 1) NOT NULL,
	Inscritos INT NOT NULL,
	Titulo varchar(80) NOT NULL,
	Descricao varchar(140));

CREATE CLUSTERED INDEX id ON tbl_lista (id);

DROP TABLE tbl_temas;
CREATE TABLE tbl_temas (
	Id INT IDENTITY(1, 1) NOT NULL,
	Nome varchar(80) NOT NULL,
	Descricao varchar(140),
	Conteudo VARCHAR(max) NOT NULL);

CREATE CLUSTERED INDEX id ON tbl_temas (id);