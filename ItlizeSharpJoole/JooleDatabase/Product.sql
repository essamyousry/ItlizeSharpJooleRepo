CREATE TABLE [dbo].[Product]
(
	ProductID int Primary Key,
	ProductName varchar(50),
	ProductImage varchar(50),
	Series varchar(50),
	Model varchar(50),
	ModelYear int,
	Manufacturer varchar(50),
	SeriesInfo varchar(50),
	SubCategoryID int not null,
	Constraint FK_SubCategoryID Foreign Key (SubCategoryID) References SubCategory(SubCategoryID)
)
