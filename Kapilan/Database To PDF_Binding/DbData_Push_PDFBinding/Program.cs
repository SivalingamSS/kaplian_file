using BusinessLibrary.Class;
using BusinessLibrary.Interface;
using DataBase.DB;
using DataLibrary.Class;
using DataLibrary.Interafce;
using Microsoft.EntityFrameworkCore;

namespace DbData_Push_PDFBinding
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
            builder.Services.AddDbContext<DBContext>(options =>
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