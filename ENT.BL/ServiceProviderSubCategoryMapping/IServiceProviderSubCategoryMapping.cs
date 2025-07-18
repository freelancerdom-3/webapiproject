using ENT.Model.Common;
using ENT.Model.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.ServiceProviderSubCategoryMapping
{
    public interface IServiceProviderSubCategoryMapping
    {
        Task<APIResponseModel> GetByArea(string areaName);
        Task<APIResponseModel> GetBySubCategoryName(string SubCategoryName);
        Task<APIResponseModel> GetBySkill(SkillViewModel objSkill);

        Task<APIResponseModel> HasSkills(int userId);
       
    }
}
