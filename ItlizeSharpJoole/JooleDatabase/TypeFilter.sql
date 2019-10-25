CREATE TABLE [dbo].[TypeFilter]
(
	PropertyID int not null,
	SubCategoryID int not null,
	TypeName varchar(50) not null,
	TypeOptions varchar(50) not null,
	Constraint PK_PSTypeFilter Primary Key (PropertyID, SubCategoryID),
	Constraint FK_TypeFilter Foreign Key (PropertyID) References Property(PropertyID),
	Constraint FK_SCTypeFilter Foreign Key (SubCategoryID) References SubCategory(SubCategoryID)
)
