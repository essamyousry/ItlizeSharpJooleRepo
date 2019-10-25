CREATE TABLE [dbo].[SubCategory]
(
	SubCategoryID int Primary Key,
	SubCategoryName varchar(50) not null,
	CategoryID int not null,
	Constraint FK_CategoryID Foreign Key (CategoryID) References Category(CategoryID)
)
