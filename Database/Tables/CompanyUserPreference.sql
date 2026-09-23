CREATE TABLE [dbo].[CompanyUserPreference]
(
	[Id]			UNIQUEIDENTIFIER	NOT NULL,
	[CompanyId]		UNIQUEIDENTIFIER	NOT NULL,

	CONSTRAINT [PK_CompanyUserPreference] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_CompanyUserPreference_UserPreference_Id] FOREIGN KEY ([Id]) REFERENCES [dbo].[UserPreference] ([Id]),
	CONSTRAINT [FK_CompanyUserPreference_Company_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Company] ([Id])
);
GO

CREATE NONCLUSTERED INDEX [IX_CompanyUserPreference_CompanyId]
	ON [dbo].[CompanyUserPreference] ([CompanyId]);
GO