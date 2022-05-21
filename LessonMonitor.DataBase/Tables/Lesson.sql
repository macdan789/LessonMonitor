CREATE TABLE [dbo].[Lesson]
(
	[LessonID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [LessonName] NVARCHAR(50) NOT NULL, 
    [Duration] TIMESTAMP NOT NULL, 
    [StartDate] DATETIME NOT NULL, 
    [Teacher] NVARCHAR(50) NULL, 
    [Groups] NVARCHAR(100) NULL
)
