CREATE TABLE [dbo].[tbl_HidraSite] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
	[IdWebSiteSettings] int,
	[URL] varchar(80) not null,
	[DBDatabase] varchar(120) not null,
	[DBServer] varchar(120) not null,
	[DBPort] varchar(120) not null,
	[DBLogin] varchar(120) not null,
	[DBUserId] varchar(120) not null,
	[DBPassword] varchar(120) not null,
	[DBTrustedConnection] varchar(50) not null,
	[DBEncrypt] varchar(50) not null,
	[DBConnectionTimeOut] varchar(20) not null,
	[HasBlog] bit not null,
	[HasPodcast] bit not null,
	[HasSlides] bit not null,
	[HasHistorys] bit not null,
	[HasEmailMarketing] bit not null,
	[HasEmail] bit not null,
	[HasStore] bit not null,
	[HasSpecial] bit not null,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[tbl_HidraUser] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
	[IdHidraSite] int not null,
	[IdAuthor] int,
	[Level] int not null,
	[Email] varchar(120) not null unique,
	[Password]varchar(120) not null,
	[LastLogin] varchar(25) not null,
	[FirstLogin]varchar(25) not null,


    PRIMARY KEY CLUSTERED ([Id] ASC)
);
