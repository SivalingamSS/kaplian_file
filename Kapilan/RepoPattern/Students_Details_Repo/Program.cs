using Microsoft.EntityFrameworkCore;
using Students_Detalis_Business.Class;
using Students_Detalis_Business.Interface;
using Students_Detalis_Data.Class;
using Students_Detalis_Data.Interface;
using Students_Detalis_dbcontext;

namespace Students_Details_Repo
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
            builder.Services.AddDbContext<Students_dbcontext>(options =>
             options.UseSqlServer(builder.Configuration.GetConnectionString("MVC6CrudConnectionString")));
            builder.Services.AddTransient<IBusiness, BusinessClass>();
            builder.Services.AddTransient<IData, DataClass>();
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