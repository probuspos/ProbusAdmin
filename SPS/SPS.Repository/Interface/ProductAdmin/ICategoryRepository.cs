using SPS.Data.Models;
using SPS.Repository.Interface.Common;
using SPS.Repository.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS.Repository.Interface.ProductAdmin
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
       IEnumerable<Category> GetCategory();

       void AddCategory(Category category);
    }
}
