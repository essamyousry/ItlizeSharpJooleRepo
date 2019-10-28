using Joole.DAL;
using Joole.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole.Services
{
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

        public List<TechSpecFilter> getSpecFiltersBySub(int id)
        {
            return unitOfWork.techSpecFilterRepo.GetGeneralTechSpecPropertiesBySubCategory(id);
        }

        public List<TechSpecFilter> getSpecFilters(int sub)
        {
            return unitOfWork.techSpecFilterRepo.GetGeneralTechSpecPropertiesBySubCategory(sub);
        }
    }
}
