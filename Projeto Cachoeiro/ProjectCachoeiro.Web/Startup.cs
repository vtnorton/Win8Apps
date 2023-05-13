using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectCachoeiro.Web.Data;
using ProjectCachoeiro.Web.Models;
using ProjectCachoeiro.Web.Services;
using Newtonsoft.Json.Serialization;

namespace ProjectCachoeiro.Web
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //TODO: config => config.SignIn.RequireConfirmedEmail = true
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<IEmailSender, EmailSender>();
            services.AddMvc().AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
            services.AddKendo();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
                app.UseDatabaseErrorPage();
            }
            else
            {
                //TODO: Alterar página de erro
                app.UseExceptionHandler("/Dashboard/Error");
            }

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes => { routes.MapRoute(name: "default", template: "{controller=Dashboard}/{action=Index}/{id?}"); });
            app.UseKendo(env);
        }
    }
}
