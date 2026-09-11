IF NOT EXISTS (
    SELECT 1
    FROM DatabaseMigrations
    WHERE ScriptName = 'M02_Company_Data_Seeding'
)
BEGIN
    INSERT INTO Company (CompanyCode, CompanyName)
    VALUES
        ('INTEL', 'Intel'),
        ('DELL', 'Dell'),
        ('LENOVO', 'Lenovo');

    INSERT INTO DatabaseMigrations (ScriptName)
    VALUES ('M02_Company_Data_Seeding');
END
