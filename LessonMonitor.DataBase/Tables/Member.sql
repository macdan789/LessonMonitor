CREATE TABLE [dbo].[Member]
(
	[MemberID] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [FirstName] NCHAR(20) NOT NULL, 
    [LastName] NCHAR(20) NOT NULL, 
    [Age] INT NOT NULL, 
    [Group] NCHAR(10) NULL DEFAULT 'Empty'
)
