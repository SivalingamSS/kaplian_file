using BLL.Sample.Interface;
using BLL.Sample.Service;
using DAL.Sample.Interface;
using DAL.Sample.Service;
using Entities.Sample.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Sample.DependencyInjection
{
    public class InfrastructureConfiguration
    {
        public static void AddDataBase(IServiceCollection service,IConfiguration configure) 
        {
            service.AddDbContext<DBcontext>(option=>option.UseSqlServer(configure.GetConnectionString("DefaultConnection")));
        }

        public static void AddServices(IServiceCollection service)
        {
            service.AddTransient<ISampleBusiness,SampleBusiness>();
            service.AddTransient<ISampleData,SampleData>();
        }
    }
}
