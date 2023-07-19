CREATE TABLE [dbo].[Joke] (
    [Id]           NVARCHAR (450) NOT NULL,
    [jokeQuestion] NVARCHAR (MAX) NULL,
    [jokeAnswer]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Joke] PRIMARY KEY CLUSTERED ([Id] ASC)
);

