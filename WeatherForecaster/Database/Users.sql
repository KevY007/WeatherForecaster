﻿CREATE TABLE [dbo].[Users]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] VARCHAR(32) NOT NULL UNIQUE, 
    [Email] VARCHAR(32) NOT NULL, 
    [Password] VARCHAR(32) NOT NULL, 
    [Salt] VARCHAR(24) NOT NULL, 
    [PrivilegeLevel] TINYINT NOT NULL DEFAULT 0,
    [Celcius] BIT NOT NULL DEFAULT 1
)
