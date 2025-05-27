using ENT.Model.Common;
using ENT.Model.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.Model.Common;

namespace ENT.BL.Category
{
    public class Category:ICategory
    {
        public Category() { }

        public Task<APIResponseModel> Add(CategoryModel objCategory)
        {
            throw new NotImplementedException();
        }

        public Task<APIResponseModel> Delete(int CategoryId)
        {
            throw new NotImplementedException();
        }

        public Task<APIResponseModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<APIResponseModel> GetById(int CategoryId)
        {
            throw new NotImplementedException();
        }

        public Task<APIResponseModel> Update(CategoryModel objCategory)
        {
            throw new NotImplementedException();
        }

        
    }
}
