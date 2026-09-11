CREATE TABLE [dbo].[CompanyActivityLog]
(
	[Id] UNIQUEIDENTIFIER NOT NULL,
    [CompanyId] UNIQUEIDENTIFIER NOT NULL,

	CONSTRAINT [PK_CompanyActivityLogId]
		PRIMARY KEY CLUSTERED ([Id]),

	CONSTRAINT [FK_CompanyActivityLog_Id]
        FOREIGN KEY ([Id])
        REFERENCES [dbo].[ActivityLog] ([Id]),

	CONSTRAINT [FK_CompanyActivityLog_CompanyId]
        FOREIGN KEY ([CompanyId])
        REFERENCES [dbo].[Company] ([Id]),

	INDEX [IX_CompanyActivityLog_CompanyId]
        NONCLUSTERED ([CompanyId])
);