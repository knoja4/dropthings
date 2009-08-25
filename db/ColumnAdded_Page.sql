IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'Page' AND COLUMN_NAME = 'IsLocked')
BEGIN
	ALTER TABLE Page ADD IsLocked bit NULL
END

GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'Page' AND COLUMN_NAME = 'LockedAt')
BEGIN
	ALTER TABLE Page ADD LockedAt datetime NULL
END

GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'Page' AND COLUMN_NAME = 'IsUnlocked')
BEGIN
	ALTER TABLE Page ADD IsUnlocked bit NULL
END

GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'Page' AND COLUMN_NAME = 'UnlockedAt')
BEGIN
	ALTER TABLE Page ADD UnlockedAt datetime NULL
END

GO