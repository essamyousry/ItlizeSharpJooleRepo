using Joole.DAL;
using Joole.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Joole.Services
{
    public class FilterService
    {
        private readonly UnitOfWork unitOfWork;

        public FilterService(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Category> GetCategories()
        {
            return unitOfWork.categoryRepo.GetCategories();
        }

        public Category GetCategoryIDFromName(string name)
        {
            return unitOfWork.categoryRepo.Get(x => x.CategoryName == name);
        }

        public IEnumerable<SubCategory> GetSubCategories()
        {
            return unitOfWork.subCategoryRepo.GetSubCategories();
        }

        public IEnumerable<SubCategory> GetSubsforCategory(int id)
        {
            return unitOfWork.subCategoryRepo.GetMany(x => x.CategoryID == id);
        }

        public Category GetCategory(int id)
        {
            return unitOfWork.categoryRepo.GetCategory(id);
        }

        public List<string> GetCategoryNames(){
            IEnumerable<Category> Categories = GetCategories();
            List<string> categories = new List<string>();
            foreach (var item in Categories) categories.Add(item.CategoryName);
            return categories;
        }

        public IEnumerable<SelectListItem> GetSubs(int id)
        {
            IEnumerable<SelectListItem> subs = GetSubsforCategory(id)
                .Select(n => new SelectListItem
                {
                    Value = (n.SubCategoryID).ToString(),
                    Text = n.SubCategoryName
                }).ToList();
            return new SelectList(subs, "Value", "Text");
        }

        public List<string> GetSubCategoryNames()
        {
            IEnumerable<SubCategory> SubCategories = GetSubCategories();
            List<string> subcategories = new List<string>();
            foreach (var item in SubCategories) subcategories.Add(item.SubCategoryName);
            return subcategories;
        }

        public string GetSubCateogryName(int id)
        {
            return unitOfWork.subCategoryRepo.getByID(id).SubCategoryName;
        }

        public string GetCategoryNameFromSub(int id)
        {
            return unitOfWork.categoryRepo.GetCategory(unitOfWork.subCategoryRepo.getByID(id).CategoryID).CategoryName;
        }

        public List<string> GetSubCategoryNames(int id)
        {
            IEnumerable<SubCategory> SubCategories = GetSubsforCategory(id);
            List<string> subcategories = new List<string>();
            foreach (var item in SubCategories) subcategories.Add(item.SubCategoryName);
            return subcategories;
        }

        public void SaveAll()
        {
            unitOfWork.SaveAll();
        }
    }
}
