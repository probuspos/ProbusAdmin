using Microsoft.EntityFrameworkCore.Query.Internal;
using SPS.Data.Models;
using SPS.Repository.Interface.Common;
using SPS.Repository.Interface.ProductAdmin;
using SPS.Services.Interface.ProductAdmin;
using SPS.Services.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS.Services.Services.ProductAdmin
{


    public class CategoryService : EntityService<Category>, ICategoryService
    {
        public readonly ICategoryRepository _categoryRepository;

        public CategoryService(IUnitOfWork unitOfWork, ICategoryRepository categoryRepository) : base(unitOfWork, categoryRepository)
        {
            UnitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> GetCategory()
        {
            return _categoryRepository.GetCategory(); ;
        }
        public void AddCategory(Category category)
        {
            _categoryRepository.AddCategory(category);
        }
    }
}
