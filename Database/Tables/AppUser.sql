CREATE TABLE [dbo].[AppUser]
(
	[Id]					UNIQUEIDENTIFIER	NOT NULL CONSTRAINT [DF_AppUser_Id] DEFAULT NEWSEQUENTIALID(),
	[FirstName]				VARCHAR(80)			NOT NULL,
	[MiddleName]			VARCHAR(80)			NULL,
	[LastName]				VARCHAR(80)			NOT NULL,
	[Dob]					DATE				NOT NULL,
	[Email]					VARCHAR(80)			NOT NULL,
	[PasswordHash]			VARCHAR(80)			NOT NULL,
	[Admin]					BIT					NOT NULL CONSTRAINT [DF_AppUser_Admin] DEFAULT 0,
	[GlobalActivityLogId]	UNIQUEIDENTIFIER	NULL,

	CONSTRAINT [PK_AppUser] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_AppUser_GlobalActivityLog_GlobalActivityLogId] FOREIGN KEY ([GlobalActivityLogId]) REFERENCES [dbo].[GlobalActivityLog] ([Id])
);
GO

CREATE UNIQUE NONCLUSTERED INDEX [IX_AppUser_Email]
	ON [dbo].[AppUser] ([Email]);
GO

CREATE UNIQUE NONCLUSTERED INDEX [IX_AppUser_GlobalActivityLogId]
	ON [dbo].[AppUser] ([GlobalActivityLogId]);
GO