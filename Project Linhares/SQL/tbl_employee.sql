DROP TABLE tbl_employee;

CREATE TABLE tbl_employee (
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
	,Temp INT
	,DaysAtWork INT
	,State VARCHAR(100)
	,Sex VARCHAR(20)
	,Observation VARCHAR(MAX)
	,Neighborhood VARCHAR(50)
	,BirthCountry VARCHAR(100)
	,City VARCHAR(120)
	,Vacation VARCHAR(30)
	,TimeOfWork VARCHAR(30)
	,SalaryObservation VARCHAR(MAX)
	,Salary VARCHAR(30)
	,HiringDate VARCHAR(30)
	,DayOfWork VARCHAR(21)
	,Job VARCHAR(50)
	);

CREATE CLUSTERED INDEX Id ON tbl_employee (Id);