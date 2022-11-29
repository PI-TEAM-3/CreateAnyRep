using Finance.Application;
using Finance.Infrastructure;
using Finance.Models;
using Finance.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;

namespace Finance
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            string con = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<FinanceContext>(options => options.UseSqlServer(con));
            services.AddTransient<IFinanceOperationRepository, FinanceOperationRepository>();
            services.AddTransient<IFinanceOperationService, FinanceOperationService>();
            services.AddTransient<ITypeOperationRepository, TypeOperationRepository>();
            services.AddTransient<ITypeOperationService, TypeOperationService>();
            services.AddTransient<IRepositoryManager, RepositoryManager>();
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());            
        }


        public void Configure(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Finance API");
            });
            app.UseDeveloperExceptionPage();
            app.UseRouting();
            app.UseMiddleware<Middleware.ErrorHandlerMiddleware>();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); 
            });
        }
    }
}
