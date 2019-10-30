using Joole.DAL;
using Joole.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole.Services
{

    public class ProductIndividualSpec
    {
        public string PropertyName { get; set; }
        public int iValue { get; set; }
        public int ProductID { get; set; }
        public int PropertyID { get; set; }
    }
    public class filteredResults
    {
        public int SubCategoryID { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public List<string> SpecList { get; set; }
        public List<TechSpecFilter> SpecFilterList { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<ProductIndividualSpec> IndividualSpecs { get; set; }
    }

    public class ResultsService
    {
        private readonly UnitOfWork unitOfWork;
        public ResultsService(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public List<string> getSpecListForSubCategory(int sub)
        {
            IEnumerable<Property> propertyList = unitOfWork.propertyRepo.GetPropertiesByTechSpec();
            List<TechSpecFilter> filterList = new List<TechSpecFilter>();
            List<string> selectList = new List<string>();
            int count = 0;
            foreach (var item in propertyList)
            {
                filterList.Add(unitOfWork.techSpecFilterRepo.GetByPropertyAndSubCategory(item.PropertyID, sub));
                if(item.PropertyID == filterList[count].PropertyID && filterList[count].SubCategoryID == sub)
                    selectList.Add(item.PropertyName);
                count++;
            }
            return selectList;
        }

        public List<string> getSpecListForSubCategoryAndProduct(int sub)
        {
            IEnumerable<Property> propertyList = unitOfWork.propertyRepo.GetPropertiesByTechSpec();
            List<TechSpecFilter> filterList = new List<TechSpecFilter>();
            List<string> selectList = new List<string>();
            int count = 0;
            foreach (var item in propertyList)
            {
                filterList.Add(unitOfWork.techSpecFilterRepo.GetByPropertyAndSubCategory(item.PropertyID, sub));
                if (item.PropertyID == filterList[count].PropertyID && filterList[count].SubCategoryID == sub)
                    selectList.Add(item.PropertyName);
                count++;
            }
            return selectList;
        }

        public List<TechSpecFilter> getSpecFiltersBySub(int id)
        {
            return unitOfWork.techSpecFilterRepo.GetGeneralTechSpecPropertiesBySubCategory(id);
        }

        public List<TechSpecFilter> getSpecFilters(int sub)
        {
            return unitOfWork.techSpecFilterRepo.GetGeneralTechSpecPropertiesBySubCategory(sub);
        }

        public List<ProductIndividualSpec> getIndividualProperties(int subid)
        {
            IEnumerable<Property> properties = unitOfWork.propertyRepo.GetPropertiesByIndividual();
            IEnumerable<TechSpec> specs = unitOfWork.techSpecRepo.GetMany(x => x.SubCategoryID == subid);
            var results = (from t1 in properties
                           join t2 in specs on t1.PropertyID equals t2.PropertyID
                           select new ProductIndividualSpec
                           {
                               PropertyName = t1.PropertyName,
                               iValue = t2.iValue,
                               ProductID = t2.ProductID
                           }).ToList();
            return results;
        }

        public List<Product> getAllProductsBySubCategory(int sub)
        {
            return unitOfWork.productRepo.GetMany(x => x.SubCategoryID == sub).ToList();
        }

        public IEnumerable<Product> GetProductsFiltered(int sub, int year1, int year2)
        {
            return unitOfWork.productRepo.GetMany(x => x.SubCategoryID == sub && (x.ModelYear >= year1 && x.ModelYear <= year2)).ToList();
        }

        public string GetCategoryNameFromSub(int id)
        {
            return unitOfWork.categoryRepo.GetCategory(unitOfWork.subCategoryRepo.getByID(id).CategoryID).CategoryName;
        }
        /*
        public IEnumerable<filteredResults> getFilteredResults(int year1, int year2, int subid, string obj)
        {
            string CategoryName = GetCategoryNameFromSub(subid);
            string SubCategoryName = GetCategoryNameFromSub(subid);
            IEnumerable<Product> productsFiltered = GetProductsFiltered(subid, year1, year2);
            List<TechSpec> techSpecFiltered = new List<TechSpec>();
            foreach (var product in productsFiltered)
            {
                techSpecFiltered.Add(unitOfWork.techSpecRepo.Get(x => x.ProductID == product.ProductID));
            }
            List<string> techSpecList = new List<string>();
            foreach(var spec in techSpecFiltered)
            {
                techSpecList.Add(unitOfWork.propertyRepo.Get(x => x.PropertyID == spec.PropertyID).PropertyName);
            }
            

        }
        */
        
    }
}
