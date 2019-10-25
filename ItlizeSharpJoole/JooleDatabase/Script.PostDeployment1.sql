/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

Insert Into Customer(UserName, UserEmail, UserPassword) Values ('admin', 'admin@test.com', 'admin');

GO

Insert Into Category(CategoryID, CategoryName) Values (0, 'Mechanical');
Insert Into Category(CategoryID, CategoryName) Values (1, 'Electrical');
Insert Into Category(CategoryID, CategoryName) Values (2, 'Stationary');
Insert Into Category(CategoryID, CategoryName) Values (3, 'Furniture');

GO

Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) values (0, 'Fans', 1);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) values (1, 'Vaccums', 1);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) values (2, 'Toasters', 1);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) values (3, 'Couch', 3);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) values (4, 'Chair', 3);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) values (5, 'Table', 3);

GO

Insert Into Product(ProductID, ProductName, Series, Model, ModelYear, Manufacturer, SeriesInfo, SubCategoryID)
	Values(0, 'FanA', 'Series350', 'A', 2019, 'FansExpress', 'ReleaseA', 0);
Insert Into Product(ProductID, ProductName, Series, Model, ModelYear, Manufacturer, SeriesInfo, SubCategoryID)
	Values(1, 'FanB', 'Series351', 'B', 2019, 'FansExpress', 'ReleaseB', 0);
Insert Into Product(ProductID, ProductName, Series, Model, ModelYear, Manufacturer, SeriesInfo, SubCategoryID)
	Values(2, 'FanC', 'Series352', 'C', 2019, 'FansExpress', 'ReleaseC', 0);

	GO

Insert Into Product(ProductID, ProductName, Series, Model, ModelYear, Manufacturer, SeriesInfo, SubCategoryID)
	Values(3, 'TableA', 'Series90', 'A', 2019, 'TableCompany', 'ReleaseA', 5);
Insert Into Product(ProductID, ProductName, Series, Model, ModelYear, Manufacturer, SeriesInfo, SubCategoryID)
	Values(4, 'TableB', 'Series91', 'B', 2019, 'TableCompany', 'ReleaseB', 5);
Insert Into Product(ProductID, ProductName, Series, Model, ModelYear, Manufacturer, SeriesInfo, SubCategoryID)
	Values(5, 'TableC', 'Series92', 'C', 2019, 'TableCompany', 'ReleaseC', 5);

	GO

-- Inserting TechSpec Property Names
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (0, 'AirFlow (CFM)', 0, 1, 0);
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (1, 'Max Power (W)', 0, 1, 0);
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (2, 'Sound at Max Speed (dbA)', 0, 1, 0);
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (3, 'Fan Sweep Diameter (in)', 0, 1, 0);

GO

-- Inserting TechSpec Properties and related sub category
Insert Into TechSpecFilter(PropertyID, SubCategoryID, MinValue, MaxValue) Values (0, 0, 0, 100);
Insert Into TechSpecFilter(PropertyID, SubCategoryID, MinValue, MaxValue) Values (1, 0, 0, 100);
Insert Into TechSpecFilter(PropertyID, SubCategoryID, MinValue, MaxValue) Values (2, 0, 0, 100);
Insert Into TechSpecFilter(PropertyID, SubCategoryID, MinValue, MaxValue) Values (3, 0, 0, 100);

GO

-- Inserting TypeFilter Property Names
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (4, 'FanType', 1, 0, 0);
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (5, 'FanType', 1, 0, 0);
-- Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec) Values (6, '', 1, 0);

GO

--Inserting TypeFilter Properties and related sub category
Insert Into TypeFilter(PropertyID, SubCategoryID, TypeName, TypeOptions) Values (4, 0, 'Ceiling Fan', 'Multiple');
Insert Into TypeFilter(PropertyID, SubCategoryID, TypeName, TypeOptions) Values (5, 0, 'Wall Mounted Fan', 'Multiple');

GO

-- Inserting Individual Tech Spec Property Names
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (6, 'Power', 0, 0, 1);
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (7, 'Airflow', 0, 0, 1);

GO

-- Inserting Tech Spec Individual Properties for each individual product
Insert Into TechSpec(PropertyID, SubCategoryID, iValue, ProductID) Values (6, 0, 75, 0);
Insert Into TechSpec(PropertyID, SubCategoryID, iValue, ProductID) Values (7, 0, 225, 0);
