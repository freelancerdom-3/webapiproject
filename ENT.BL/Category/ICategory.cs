﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ENT.Model.Common;
using ENT.Model.Category;

namespace ENT.BL.Category
{
    public interface ICategory
    {
        // check category name should be unique in entire application , paresh will take care
        Task<APIResponseModel> Add(CategoryModel objCategory);
        Task<APIResponseModel> GetAll();
        Task<APIResponseModel> GetById(int CategoryId);
        Task<APIResponseModel> Update(CategoryModel objCategory);
        Task<APIResponseModel> Delete(int CategoryId);
    }
}
