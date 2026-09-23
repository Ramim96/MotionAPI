CREATE TABLE [dbo].[UserPreference]
(
	[Id]					UNIQUEIDENTIFIER	NOT NULL CONSTRAINT [DF_UserPreference_Id] DEFAULT NEWSEQUENTIALID(),
	[UserPreferenceType]	VARCHAR(100)		NOT NULL,
	[Value]					VARCHAR(200)		NOT NULL,
	[AppUserId]				UNIQUEIDENTIFIER	NOT NULL,

	CONSTRAINT [PK_UserPreference] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_UserPreference_AppUser_AppUserId] FOREIGN KEY ([AppUserId]) REFERENCES [dbo].[AppUser] ([Id])
);
GO

CREATE NONCLUSTERED INDEX [IX_UserPreference_AppUserId]
	ON [dbo].[UserPreference] ([AppUserId]);
GO