using BUSINESS_LAYER.Class;
using BUSINESS_LAYER.Interface;
using CUSTOMER_MODAL.dbcontext;
using DATA_LAYER.Class;
using DATA_LAYER.Interface;
using Microsoft.EntityFrameworkCore;

namespace CUSTOMER_DETAILS
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
            builder.Services.AddDbContext<dbcontact>(options =>
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