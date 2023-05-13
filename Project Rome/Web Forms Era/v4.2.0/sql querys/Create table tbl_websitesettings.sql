CREATE TABLE [dbo].[tbl_websitesetting] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
	[IdHidraSite] int not null,
	[PostOnBlog] int not null default ((10)),
	[Widget] int not null default((5)),
	[Title] varchar(50) not null,
	[Description] varchar(170) not null,
	[Keywords] varchar(1000) not null,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);