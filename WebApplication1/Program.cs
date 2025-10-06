
using API_DataBase_KillTeamWarhammer40k.Entieties;
using Microsoft.EntityFrameworkCore;

namespace API_DataBase_KillTeamWarhammer40k
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
           
            
            // Rejestracja DbContext
            builder.Services.AddDbContext<MainDbContext>(
                option => option.UseSqlServer(builder.Configuration.GetConnectionString("MainDatabase")));



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
