CREATE TABLE [dbo].[WeatherData]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
	[ParentID] INT NOT NULL,
	[ContributorID] INT NOT NULL DEFAULT -1,
	[Timestamp] VARCHAR(64) NOT NULL,
    [Temperature] FLOAT NOT NULL,
	[Cloud] INT NOT NULL,
	[Humidity] INT NOT NULL,
	[RainChance] INT NOT NULL,
	[Precipitation] FLOAT NOT NULL,
	[UVIndex] FLOAT NOT NULL,
	[WindKPH] FLOAT NOT NULL
)
