select * from Category;
select * from Product;
select * from TechSpec;
select * from Property;
select * from SubCategory;

Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) Values (6, 'Wrenches', 0);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) Values (7, 'Hammers', 0);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) Values (8, 'Nails', 0);

Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) Values (9, 'Books', 2);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) Values (10, 'Pens', 2);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) Values (11, 'Paper', 2);

Insert Into Product(ProductID, ProductName, Series, Model, ModelYear, Manufacturer, SeriesInfo, SubCategoryID)
	Values(6, 'WrenchA', 'Series21', 'A', 2019, 'WrenchCompany', 'ReleaseA', 6);
Insert Into Product(ProductID, ProductName, Series, Model, ModelYear, Manufacturer, SeriesInfo, SubCategoryID)
	Values(7, 'WrenchB', 'Series21', 'B', 2019, 'WrenchCompany', 'ReleaseB', 6);
Insert Into Product(ProductID, ProductName, Series, Model, ModelYear, Manufacturer, SeriesInfo, SubCategoryID)
	Values(8, 'WrenchC', 'Series21', 'C', 2019, 'WrenchCompany', 'ReleaseC', 6);

Insert Into Product(ProductID, ProductName, Series, Model, ModelYear, Manufacturer, SeriesInfo, SubCategoryID)
	Values(9, 'BookA', 'Series1', 'A', 2019, 'BookCompany', 'ReleaseA', 9);
Insert Into Product(ProductID, ProductName, Series, Model, ModelYear, Manufacturer, SeriesInfo, SubCategoryID)
	Values(10, 'BookB', 'Series1', 'B', 2019, 'BookCompany', 'ReleaseB', 9);
Insert Into Product(ProductID, ProductName, Series, Model, ModelYear, Manufacturer, SeriesInfo, SubCategoryID)
	Values(11, 'BookC', 'Series1', 'C', 2019, 'BookCompany', 'ReleaseC', 9);

Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (8, 'Tolerance', 0, 0, 1);
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (9, 'Weight (lb)', 0, 0, 1);

Insert Into TechSpec(PropertyID, SubCategoryID, iValue, ProductID) Values (8, 6, 2, 6);
Insert Into TechSpec(PropertyID, SubCategoryID, iValue, ProductID) Values (9, 6, 6, 6);

Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (10, 'Tolerance', 0, 0, 1);
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (11, 'Weight (lb)', 0, 0, 1);

Insert Into TechSpec(PropertyID, SubCategoryID, iValue, ProductID) Values (10, 6, 2, 7);
Insert Into TechSpec(PropertyID, SubCategoryID, iValue, ProductID) Values (11, 6, 6, 7);

Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (12, 'Tolerance', 0, 0, 1);
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (13, 'Weight (lb)', 0, 0, 1);

Insert Into TechSpec(PropertyID, SubCategoryID, iValue, ProductID) Values (12, 6, 2, 8);
Insert Into TechSpec(PropertyID, SubCategoryID, iValue, ProductID) Values (13, 6, 6, 8);

Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (14, 'Author', 1, 0, 0);
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (15, 'Author', 1, 0, 0);
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (16, 'Author', 1, 0, 0);
-- Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec) Values (6, '', 1, 0);

--Inserting TypeFilter Properties and related sub category
Insert Into TypeFilter(PropertyID, SubCategoryID, TypeName, TypeOptions) Values (14, 9, 'James', 'Massachussets');
Insert Into TypeFilter(PropertyID, SubCategoryID, TypeName, TypeOptions) Values (15, 9, 'Joe', 'Louisiana');
Insert Into TypeFilter(PropertyID, SubCategoryID, TypeName, TypeOptions) Values (16, 9, 'John', 'Kentucky');

use master

delete from SubCategory where SubCategoryID between 6 and 8;

ALTER DATABASE JooleDatabase MODIFY NAME = ItlizeSharpJooleDatabase ;

use ItlizeSharpJooleDatabase;