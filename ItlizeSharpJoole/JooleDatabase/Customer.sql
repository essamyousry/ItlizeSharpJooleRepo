CREATE TABLE [dbo].[Customer]
(
	UserID int Primary Key Identity,
	UserName varchar(50) not null,
	UserEmail varchar(50) not null,
	UserImage varchar(50),
	UserPassword varchar(50) not null
)
