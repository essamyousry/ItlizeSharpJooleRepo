CREATE TABLE [dbo].[TechSpec]
(
	PropertyID int not null,
	SubCategoryID int not null,
	iValue int not null,
	ProductID int not null,
	Constraint PK_PSTypeSpecI Primary Key(PropertyID, SubCategoryID),
	Constraint FK_TypeSpecI Foreign Key (PropertyID) References Property(PropertyID),
	Constraint FK_SCTypeSpecI Foreign Key (SubCategoryID) References SubCategory(SubCategoryID)
)
