CREATE TABLE [dbo].[Company]
(
	[Id]					UNIQUEIDENTIFIER		NOT NULL CONSTRAINT [DF_Company_Id] DEFAULT NEWSEQUENTIALID(),
	[CompanyCode]			VARCHAR(50)				NOT NULL,
	[CompanyName]			VARCHAR(100)			NOT NULL,
	[GlobalActivityLogId]	UNIQUEIDENTIFIER		NULL,

	CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_Company_GlobalActivityLog_GlobalActivityLogId] FOREIGN KEY ([GlobalActivityLogId]) REFERENCES [dbo].[GlobalActivityLog] ([Id])
);
GO

CREATE UNIQUE NONCLUSTERED INDEX [IX_Company_CompanyCode]
	ON [dbo].[Company] ([CompanyCode]);
GO

CREATE UNIQUE NONCLUSTERED INDEX [IX_Company_GlobalActivityLogId]
	ON [dbo].[Company] ([GlobalActivityLogId]);
GO