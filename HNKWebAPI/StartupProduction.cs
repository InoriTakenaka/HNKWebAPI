using HNKWebAPI.DataSource;
using HNKWebAPI.IService;
using HNKWebAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
namespace HNKWebAPI {
    public class StartupProduction {
        public StartupProduction(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddCors(o =>
            o.AddPolicy("CorsPolicy", builder =>
             builder.AllowAnyHeader()
                    .AllowAnyMethod()));
            services.AddSwaggerGen(s => {
                s.SwaggerDoc("V1", new OpenApiInfo() {
                    Title = "V1"
                });
            });
            services.AddScoped<IRbacService, RbacService>();
            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<IDepartmentService, DepartManagerService>();
            services.AddControllers();
            services.AddHttpsRedirection(options=> {
                options.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
                options.HttpsPort = 5001;
            });
            services.AddDbContext<DataSourceContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddHsts(options => {
                options.Preload = true;
                options.IncludeSubDomains = true;
                options.MaxAge = TimeSpan.FromDays(60);
                options.ExcludedHosts.Add("example.com");
                options.ExcludedHosts.Add("www.example.com");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app) {
            app.UseSwagger();
            app.UseSwaggerUI(swagger => swagger.SwaggerEndpoint("/swagger/V1/swagger.json", "V1"));
            app.UseHsts();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
