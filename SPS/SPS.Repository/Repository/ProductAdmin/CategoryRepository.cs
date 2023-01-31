using SPS.Data.Models;
using SPS.Repository.Interface.Common;
using SPS.Repository.Interface.ProductAdmin;
using SPS.Repository.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS.Repository.Repository.ProductAdmin
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(probus23Context context) : base(context)
        {
        }

        public IEnumerable<Category> GetCategory()
        {
            return Context.Categories.ToList();
        }
        public void AddCategory(Category category)
        {
             Context.Categories.Add(category);
        }
    }
}
