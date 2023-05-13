DROP TABLE tbl_user;

CREATE TABLE tbl_user 
  ( 
  Id INT IDENTITY(1, 1) NOT NULL
	,IdFarm INT NOT NULL
	,IdEmployee INT NOT NULL
    ,Accesstype INT NOT NULL
    ,Unity      INT NOT NULL 
    ,Password   VARCHAR(100) NOT NULL
    ,LastLogin  VARCHAR(30)
    ,FirstLogin VARCHAR(30) 
  ); 

CREATE CLUSTERED INDEX Id ON tbl_user (Id);