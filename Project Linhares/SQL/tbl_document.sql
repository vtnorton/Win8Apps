DROP TABLE tbl_document;

CREATE TABLE tbl_document (
	Id INT IDENTITY(1, 1) NOT NULL
	,BrazilCPF VARCHAR(14)
	,BrazilRG VARCHAR(12)
	,Passport VARCHAR(50)
	,BrazilCDTCadastro VARCHAR(50)
	,BrazilCDTDataDeEmissao VARCHAR(50)
	,BrazilCDTPIS VARCHAR(14)
	,BrazilCDTSerie VARCHAR(5)
	,BrazilCDTSigla VARCHAR(2)
	,BrazilCDTNumero VARCHAR(10)
	,BrazilCNH VARCHAR(50)
	,BrazilCNPJ VARCHAR(50)
	);

CREATE CLUSTERED INDEX Id ON tbl_document (Id); 