using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NameApi.Models;

namespace NameApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            //var connection = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            //services.AddDbContext<NameContext>(opt =>opt.UseMySQL(connection));
            var connectionEF = "Data Source=name.db";
            services.AddDbContext<NameContext>(options => options.UseSqlite(connectionEF));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }



        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
