
Insert Into Customer(UserName, UserEmail, UserPassword) Values ('admin', 'admin@test.com', 'admin');

Insert Into Category(CategoryID, CategoryName) Values (0, 'Mechanical');
Insert Into Category(CategoryID, CategoryName) Values (1, 'Electrical');
Insert Into Category(CategoryID, CategoryName) Values (2, 'Stationary');
Insert Into Category(CategoryID, CategoryName) Values (3, 'Furniture');

Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) values (0, 'Fans', 1);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) values (1, 'Vaccums', 1);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) values (2, 'Toasters', 1);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) values (3, 'Couch', 3);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) values (4, 'Chair', 3);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) values (5, 'Table', 3);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) Values (6, 'Wrenches', 0);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) Values (7, 'Hammers', 0);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) Values (8, 'Nails', 0);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) Values (9, 'Books', 2);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) Values (10, 'Pens', 2);
Insert Into SubCategory(SubCategoryID, SubCategoryName, CategoryID) Values (11, 'Paper', 2);

Insert Into Product(ProductID, ProductName, Series, Model, ModelYear, Manufacturer, SeriesInfo, SubCategoryID)
	Values(0, 'FanA', 'Series350', 'A', 2019, 'FansExpress', 'ReleaseA', 0);
Insert Into Product(ProductID, ProductName, Series, Model, ModelYear, Manufacturer, SeriesInfo, SubCategoryID)
	Values(1, 'FanB', 'Series351', 'B', 2019, 'FansExpress', 'ReleaseB', 0);
Insert Into Product(ProductID, ProductName, Series, Model, ModelYear, Manufacturer, SeriesInfo, SubCategoryID)
	Values(2, 'FanC', 'Series352', 'C', 2019, 'FansExpress', 'ReleaseC', 0);
Insert Into Product(ProductID, ProductName, Series, Model, ModelYear, Manufacturer, SeriesInfo, SubCategoryID)
	Values(3, 'TableA', 'Series90', 'A', 2019, 'TableCompany', 'ReleaseA', 5);
Insert Into Product(ProductID, ProductName, Series, Model, ModelYear, Manufacturer, SeriesInfo, SubCategoryID)
	Values(4, 'TableB', 'Series91', 'B', 2019, 'TableCompany', 'ReleaseB', 5);
Insert Into Product(ProductID, ProductName, Series, Model, ModelYear, Manufacturer, SeriesInfo, SubCategoryID)
	Values(5, 'TableC', 'Series92', 'C', 2019, 'TableCompany', 'ReleaseC', 5);
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

-- Inserting TechSpec Property Names
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (0, 'AirFlow (CFM)', 0, 1, 0);
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (1, 'Max Power (W)', 0, 1, 0);
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (2, 'Sound at Max Speed (dbA)', 0, 1, 0);
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (3, 'Fan Sweep Diameter (in)', 0, 1, 0);

-- Inserting TechSpec Properties and related sub category
Insert Into TechSpecFilter(PropertyID, SubCategoryID, MinValue, MaxValue) Values (0, 0, 0, 100);
Insert Into TechSpecFilter(PropertyID, SubCategoryID, MinValue, MaxValue) Values (1, 0, 0, 100);
Insert Into TechSpecFilter(PropertyID, SubCategoryID, MinValue, MaxValue) Values (2, 0, 0, 100);
Insert Into TechSpecFilter(PropertyID, SubCategoryID, MinValue, MaxValue) Values (3, 0, 0, 100);

-- Inserting TypeFilter Property Names
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (4, 'FanType', 1, 0, 0);
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (5, 'FanType', 1, 0, 0);
-- Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec) Values (6, '', 1, 0);

--Inserting TypeFilter Properties and related sub category
Insert Into TypeFilter(PropertyID, SubCategoryID, TypeName, TypeOptions) Values (4, 0, 'Ceiling Fan', 'Multiple');
Insert Into TypeFilter(PropertyID, SubCategoryID, TypeName, TypeOptions) Values (5, 0, 'Wall Mounted Fan', 'Multiple');

-- Inserting Individual Tech Spec Property Names
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (6, 'Power', 0, 0, 1);
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (7, 'Airflow', 0, 0, 1);

-- Inserting Tech Spec Individual Properties for each individual product
Insert Into TechSpec(PropertyID, SubCategoryID, iValue, ProductID) Values (6, 0, 75, 0);
Insert Into TechSpec(PropertyID, SubCategoryID, iValue, ProductID) Values (7, 0, 225, 0);

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

Insert Into TypeFilter(PropertyID, SubCategoryID, TypeName, TypeOptions) Values (14, 9, 'James', 'Massachussets');
Insert Into TypeFilter(PropertyID, SubCategoryID, TypeName, TypeOptions) Values (15, 9, 'Joe', 'Louisiana');
Insert Into TypeFilter(PropertyID, SubCategoryID, TypeName, TypeOptions) Values (16, 9, 'John', 'Kentucky');

Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (17, 'Power', 0, 0, 1);
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (18, 'Airflow', 0, 0, 1);

Insert Into TechSpec(PropertyID, SubCategoryID, iValue, ProductID) Values (17, 0, 3, 1);
Insert Into TechSpec(PropertyID, SubCategoryID, iValue, ProductID) Values (18, 0, 8, 1);

Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (19, 'Power', 0, 0, 1);
Insert Into Property(PropertyID, PropertyName, IsType, IsTechSpec, IsIndividual) Values (20, 'Airflow', 0, 0, 1);

Insert Into TechSpec(PropertyID, SubCategoryID, iValue, ProductID) Values (19, 0, 6, 2);
Insert Into TechSpec(PropertyID, SubCategoryID, iValue, ProductID) Values (20, 0, 12, 2);