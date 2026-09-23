CREATE TABLE [dbo].[CompanyActivityLog]
(
	[Id]			UNIQUEIDENTIFIER	NOT NULL,
	[CompanyId]		UNIQUEIDENTIFIER	NOT NULL,

	CONSTRAINT [PK_CompanyActivityLog] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_CompanyActivityLog_ActivityLog_Id] FOREIGN KEY ([Id]) REFERENCES [dbo].[ActivityLog] ([Id]),
	CONSTRAINT [FK_CompanyActivityLog_Company_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Company] ([Id])
);
GO

CREATE NONCLUSTERED INDEX [IX_CompanyActivityLog_CompanyId]
	ON [dbo].[CompanyActivityLog] ([CompanyId]);
GO