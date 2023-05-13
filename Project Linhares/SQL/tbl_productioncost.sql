DROP TABLE tbl_productioncost;

CREATE TABLE tbl_productioncost (
	Id INT IDENTITY(1, 1) NOT NULL
	,IdFarm INT NOT NULL
	,Fertilizer MONEY
	,MicroNutrients MONEY
	,Herbicide MONEY
	,Fungicide MONEY
	,Insecticide MONEY
	,Manure MONEY
	,Fuel MONEY
	,Lubricant MONEY
	,CleaningEquipament MONEY
	,Tools MONEY
	,Accessories MONEY
	,Others MONEY
	,Employee MONEY
	,TempEmployee MONEY
	,Overtime MONEY
	,Eletricity MONEY
	,MachineMaintenance MONEY
	,PublicTransport MONEY
	,ThirdpartyTransport MONEY
	,ServicesOthers MONEY
	,TotalServices MONEY
	,TotalCompras MONEY
	,TotalCost MONEY
	,Description VARCHAR(1240)
	,Username VARCHAR(50)
	,TimeOfPost VARCHAR(30)
	,MonthOfReference VARCHAR(30)
	);

CREATE CLUSTERED INDEX Id ON tbl_productioncost (Id); 