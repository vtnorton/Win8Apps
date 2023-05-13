CREATE TABLE [dbo].[tbl_author] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50)  NOT NULL,
    [Description] VARCHAR (240) NOT NULL,
    [URLProfile]  VARCHAR (100) NOT NULL,
    [URLCover]    VARCHAR (100) NOT NULL,
    [URL]         VARCHAR (100) NULL,
    [Job]         VARCHAR (100) NULL,
    [Birthday]    VARCHAR (10)  NOT NULL,
    [Email]       VARCHAR (100) NOT NULL,
    [Password]    VARCHAR (50)  NOT NULL,
    [FirstLogin]  VARCHAR (20)  NOT NULL,
    [LastLogin]   VARCHAR (20)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[tbl_bug] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Upvotes]        INT           NULL,
    [Date]           VARCHAR (19)  NULL,
    [Project]        VARCHAR (80)  NULL,
    [Menssage]       VARCHAR (MAX) NULL,
    [Status]         VARCHAR (30)  NULL,
    [StatusCSSClass] VARCHAR (33)  NULL,
    [Email]          VARCHAR (100) NULL,
    [Type]           VARCHAR (20)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[tbl_category] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50)  NOT NULL,
    [UrlIcon]     VARCHAR (120) NOT NULL,
    [UrlCover]    VARCHAR (120) NOT NULL,
    [Description] VARCHAR (240) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[tbl_post] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [IdCategory]     INT            NOT NULL,
    [IdAuthor]       INT            NOT NULL,
    [Title]          NVARCHAR (120)   NOT NULL,
    [URL]            VARCHAR (150)   NOT NULL,
    [URLImage]       NVARCHAR (190)  NULL,
    [AuthorName]     NVARCHAR (100) NULL,
    [CategoryName]   NVARCHAR (100)   NULL,
    [FirstParagraph] NVARCHAR (MAX)  NULL,
    [Content]        NVARCHAR (MAX)  NOT NULL,
    [PostedDate]     VARCHAR (25)   NOT NULL,
    [UpdatedDate]    VARCHAR (25)   NOT NULL,
    [Online]         INT            NOT NULL,
    [Visits]         INT            DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

