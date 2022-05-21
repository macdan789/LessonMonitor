CREATE TABLE [dbo].[Group]
(
	[GroupID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [GroupName] NVARCHAR(50) NOT NULL, 
    [MemberCount] INT NULL, 
    [Curator] NVARCHAR(50) NOT NULL DEFAULT 'Empty'
)
