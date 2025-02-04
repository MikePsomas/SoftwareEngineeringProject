CREATE TABLE [dbo].[IdeaTable] (
    [Idea_id]               INT           IDENTITY (1, 1) NOT NULL,
    [Risk_rating]           VARCHAR (1)   NULL,
    [Abstract]              VARCHAR (200) NULL,
    [Country_availability]  VARCHAR (50)  NULL,
    [Regional_availability] VARCHAR (50)  NULL,
    [Currency_type]         VARCHAR (20)  NULL,
    [Idea_type]             VARCHAR (50)  NULL,
    [Publish_date]          VARCHAR (50)  NULL,
    [Expire_date]           VARCHAR (50)  NULL,
    [Idea_title]            VARCHAR (50)  NULL,
    [Idea_document]         VARCHAR (MAX) NULL,
    [Minor_sector]          VARCHAR (50)  NULL,
    [Major_sector]          VARCHAR (50)  NULL,
    [Author]                VARCHAR (50)  NULL,
    [Assigned To] VARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([Idea_id] ASC)
);

