DROP TABLE tbl_usercoffee;

CREATE TABLE tbl_usercoffee (
	Id INT IDENTITY(1, 1) NOT NULL
	,IdFarm INT NOT NULL
	,IdCoffee INT NOT NULL
	,IsHarvest INT NOT NULL
	,NAME INT NOT NULL
	,Plantation INT
	,BeginningOfPlantation VARCHAR(10)
	,AfterPlantation VARCHAR(10)
	,Flowering INT
	,BeginningOfFlowering VARCHAR(10)
	,AfterFlowering VARCHAR(10)
	,Harvest INT
	,BeginningOfHarvest VARCHAR(10)
	,AfterHarvest VARCHAR(10)
	,Processing INT
	,BeginningOfProcessing VARCHAR(10)
	,AfterProcessing VARCHAR(10)
	,Drying INT
	,BeginningOfDrying VARCHAR(10)
	,AfterDrying VARCHAR(10)
	,Roasting INT
	,BeginningOfRoasting VARCHAR(10)
	,AfterRoasting VARCHAR(10)
	,Grinding INT
	,BeginningOfGrinding VARCHAR(10)
	,AfterGrinding VARCHAR(10)
	,Classification INT
	,BeginningOfClassification VARCHAR(10)
	,AfterClassification VARCHAR(10)
	,Packing INT
	,BeginningOfPacking VARCHAR(10)
	,AfterPacking VARCHAR(10)
	,Boxing INT
	,BeginningOfBoxing VARCHAR(10)
	,AfterBoxing VARCHAR(10)
	);

CREATE CLUSTERED INDEX id ON tbl_usercoffee (id);