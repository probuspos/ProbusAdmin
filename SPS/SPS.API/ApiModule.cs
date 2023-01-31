using SPS.Repository.Interface.Common;
using SPS.Repository.Interface.ProductAdmin;
using SPS.Repository.Repository.Common;
using SPS.Repository.Repository.ProductAdmin;
using SPS.Services.Interface.ProductAdmin;
using SPS.Services.Services.ProductAdmin;

namespace SPS.API
{
    public static class ApiModule 
    {
        public static void RegisterDependecy(IServiceCollection services)
        {
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

            //Services
            services.AddScoped(typeof(ICategoryService), typeof(CategoryService));

            //Repository
            services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));


        }

    }
}
