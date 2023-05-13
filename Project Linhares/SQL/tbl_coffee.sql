DROP TABLE tbl_coffee;

CREATE TABLE tbl_coffee (
	Id INT IDENTITY(1, 1) NOT NULL
	,Region VARCHAR(90) NOT NULL
	,Type VARCHAR(90) NOT NULL
	,Plantation INT
	,Flowering INT
	,Harvest INT
	,Processing INT
	,Drying INT
	,Roasting INT
	,Grinding INT
	,Classification INT
	,Packing INT
	,Boxing INT
	);

CREATE CLUSTERED INDEX id ON tbl_coffee (id);