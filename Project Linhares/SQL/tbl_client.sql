DROP TABLE tbl_client;

CREATE TABLE tbl_client (
	Id INT IDENTITY(1, 1) NOT NULL
	,IdFarm INT NOT NULL
	,Name VARCHAR(25) NOT NULL
	,LastName VARCHAR(25) NOT NULL
	,NickName VARCHAR(25)
	,Email VARCHAR(150)
	,Phone VARCHAR(20)
	,IdDocument INT NOT NULL
	,Address VARCHAR(200)
	,Birthday VARCHAR(30)
	,State VARCHAR(100)
	,Sex VARCHAR(1)
	,Observation VARCHAR(MAX)
	,Neighborhood VARCHAR(50)
	,BirthCountry VARCHAR(100)
	,City VARCHAR(120)
	);

CREATE CLUSTERED INDEX id ON tbl_client (id);