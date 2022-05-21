CREATE TABLE [dbo].[Teacher]
(
	[TeacherID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Age] INT NULL, 
    [Group] NVARCHAR(50) NOT NULL DEFAULT 'Empty',
    [Specification] NVARCHAR(50) NOT NULL DEFAULT 'General',
)
