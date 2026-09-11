CREATE TABLE [dbo].[DatabaseMigrations]
(
    [Id] UNIQUEIDENTIFIER NOT NULL
        CONSTRAINT [DF_DatabaseMigrationsId] DEFAULT NEWSEQUENTIALID(),

    [ScriptName] VARCHAR(200) NOT NULL,

    [ExecutedAt] DATETIME NOT NULL
        CONSTRAINT [DF_DatabaseMigrationsExecutedAt] DEFAULT GETDATE(),

    CONSTRAINT [PK_DatabaseMigrationsId]
        PRIMARY KEY CLUSTERED ([Id]),

    INDEX [IX_DatabaseMigrations_ScriptName]
        NONCLUSTERED ([ScriptName])
);