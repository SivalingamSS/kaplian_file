using Business_Layer;
using Business_Layer.Interface_BL;
using DataAccess_Layer;
using DataAccess_Layer.Interface_DAL;
using Microsoft.EntityFrameworkCore;
using Model;

namespace curd_repository
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<dbcontext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("MVC6CrudConnectionString")));
            builder.Services.AddTransient<IBusiness, Business>();
            builder.Services.AddTransient<IData, Data>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}