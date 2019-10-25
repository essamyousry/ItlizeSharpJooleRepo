CREATE TABLE [dbo].[TechSpecFilter]
(
	PropertyID int not null,
	SubCategoryID int not null,
	MinValue int not null,
	MaxValue int not null,
	Constraint PK_PSTypeSpec Primary Key(PropertyID, SubCategoryID),
	Constraint FK_TypeSpec Foreign Key (PropertyID) References Property(PropertyID),
	Constraint FK_SCTypeSpec Foreign Key (SubCategoryID) References SubCategory(SubCategoryID)
)
