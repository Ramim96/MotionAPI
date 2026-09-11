CREATE TABLE [dbo].[GlobalActivityLog]
(
	[Id] UNIQUEIDENTIFIER NOT NULL,

	CONSTRAINT [PK_GlobalActivityLogId]
		PRIMARY KEY CLUSTERED ([Id]),

	CONSTRAINT [FK_GlobalActivityLog_Id]
        FOREIGN KEY ([Id])
        REFERENCES [dbo].[ActivityLog] ([Id]),
);