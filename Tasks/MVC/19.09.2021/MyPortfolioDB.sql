SET NOCOUNT ON
GO

USE master
GO
if exists (select * from sysdatabases where name='MyPortfolioDB')
		drop database MyPortfolioDB
go

DECLARE @device_directory NVARCHAR(520)
SELECT @device_directory = SUBSTRING(filename, 1, CHARINDEX(N'master.mdf', LOWER(filename)) - 1)
FROM master.dbo.sysaltfiles WHERE dbid = 1 AND fileid = 1

EXECUTE (N'CREATE DATABASE MyPortfolioDB
  ON PRIMARY (NAME = N''MyPortfolioDB'', FILENAME = N''' + @device_directory + N'myportfoliodb.mdf'')
  LOG ON (NAME = N''MyPortfolioDB_log'',  FILENAME = N''' + @device_directory + N'myportfoliodb.ldf'')')
go

--exec sp_dboption 'MyPortfolioDB','trunc. log on chkpt.','true'
--exec sp_dboption 'MyPortfolioDB','select into/bulkcopy','true'
GO

set quoted_identifier on
GO

SET DATEFORMAT mdy
GO
use "MyPortfolioDB"
go

CREATE TABLE [Contact] (
	Id integer IDENTITY(1,1)  NOT NULL,
	Mail varchar(255) NOT NULL UNIQUE,
	Password varchar(255) NOT NULL UNIQUE,
  CONSTRAINT [PK_CONTACT] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Article] (
	Id integer IDENTITY(1,1)  NOT NULL,
	Title varchar(255) NOT NULL,
	Site varchar(255) NOT NULL,
	Link varchar(255) NOT NULL,
	Image varchar(255),
	Description varchar(255),
	Date datetime,
  CONSTRAINT [PK_ARTICLE] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Resume] (
	Id integer IDENTITY(1,1)  NOT NULL,
	Title varchar(255) NOT NULL,
	StartDate datetime NOT NULL,
	FinishDate datetime,
	Type varchar(255) NOT NULL,
  CONSTRAINT [PK_RESUME] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [WorkCategory] (
	Id integer IDENTITY(1,1)  NOT NULL,
	Title varchar(255) NOT NULL,
	ClassName varchar(255) NOT NULL,
  CONSTRAINT [PK_WORKCATEGORY] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Service] (
	Id integer IDENTITY(1,1)  NOT NULL,
	Title varchar(255) NOT NULL UNIQUE,
	Description varchar(255) NOT NULL UNIQUE,
	Icon varchar(255) NOT NULL,
  CONSTRAINT [PK_SERVICE] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [About] (
	Id integer IDENTITY(1,1)  NOT NULL,
	FirstName varchar(255) NOT NULL,
	Surname varchar(255) NOT NULL,
	Age integer(2) NOT NULL,
	Location varchar(255) NOT NULL,
	Phone varchar(255) NOT NULL,
	Email varchar(255) NOT NULL,
	Description varchar(255),
	Title varchar(255) NOT NULL,
	Title2 varchar(255) NOT NULL,
	Image varchar(255),
  CONSTRAINT [PK_ABOUT] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Header] (
	Id integer IDENTITY(1,1)  NOT NULL,
	Instagram varchar(255) NOT NULL,
	Facebook varchar(255) NOT NULL,
	LinkedIn varchar(255) NOT NULL,
	Github varchar(255) NOT NULL,
	Description varchar(255),
	Image varchar(255),
  CONSTRAINT [PK_HEADER] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Work] (
	Id integer IDENTITY(1,1)  NOT NULL,
	Title varchar(255) NOT NULL,
	Link varchar(255) NOT NULL,
	CategoryId integer NOT NULL,
	StartTime datetime NOT NULL,
	FinishTime datetime NOT NULL,
	Image varchar(255) NOT NULL,
	Description varchar(255) NOT NULL,
  CONSTRAINT [PK_WORK] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

ALTER TABLE [Work] WITH CHECK ADD CONSTRAINT [Work_fk0] FOREIGN KEY ([CategoryId]) REFERENCES [WorkCategory]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [Work] CHECK CONSTRAINT [Work_fk0]
GO
