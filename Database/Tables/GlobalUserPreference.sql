CREATE TABLE [dbo].[GlobalUserPreference]
(
	[Id]			UNIQUEIDENTIFIER	NOT NULL,

	CONSTRAINT [PK_GlobalUserPreference] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_GlobalUserPreference_UserPreference_Id] FOREIGN KEY ([Id]) REFERENCES [dbo].[UserPreference] ([Id])
);
GO