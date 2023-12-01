using BusinessLayer.Class;
using BusinessLayer.Interface;
using ConsoleApp1.Infrastructure;
using DataLayer.Class;
using DataLayer.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            DependencyInjection.DependencyRegistrartion(builder.Services);

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseMiddleware<MiddleWare>();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}