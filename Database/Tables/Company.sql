CREATE TABLE [dbo].[Company]
(
    [Id] UNIQUEIDENTIFIER NOT NULL
        CONSTRAINT [DF_CompanyId] DEFAULT NEWSEQUENTIALID(),

    [CompanyCode] VARCHAR(30) NOT NULL,
    [CompanyName] VARCHAR(100) NOT NULL,
    [GlobalActivityLogId] UNIQUEIDENTIFIER NULL,

    CONSTRAINT [PK_CompanyId]
        PRIMARY KEY CLUSTERED ([Id]),

    CONSTRAINT [FK_Company_GlobalActivityLogId]
        FOREIGN KEY ([GlobalActivityLogId])
        REFERENCES [dbo].[GlobalActivityLog] ([Id]),

    INDEX [IX_Company_CompanyCode]
        NONCLUSTERED ([CompanyCode]),

    INDEX [IX_Company_GlobalActivityLogId]
        NONCLUSTERED ([GlobalActivityLogId])
);