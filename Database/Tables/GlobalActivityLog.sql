CREATE TABLE [dbo].[GlobalActivityLog]
(
	[Id] UNIQUEIDENTIFIER NOT NULL,

	CONSTRAINT [PK_GlobalActivityLog] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_GlobalActivityLog_ActivityLog_Id] FOREIGN KEY ([Id]) REFERENCES [dbo].[ActivityLog] ([Id])
);
GO