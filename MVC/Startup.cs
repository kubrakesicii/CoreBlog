using API.Extension;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Context;
using DataAccess.GenericRepository;
using DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.InstallSwagger();
            services.InstallDatabase(Configuration);
            services.InstallApi();

            // Add services to the container.
            services.AddControllersWithViews();


            services.AddDbContext<BlogContext>();

            var connectionString = Configuration.GetConnectionString("MysqlConnection");
            services.AddDbContext<BlogContext>(options =>
            {
                options.UseMySql("Server=127.0.0.1;Database=BlogDb;Uid=root;Pwd=123456;", new MySqlServerVersion(new Version("8.0.30")));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IBlogService, BlogService>();
            services.AddTransient<ICommentService, CommentService>();
            services.AddTransient<IAboutService, AboutService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IContactService, ContactService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.ConfigureSwagger();
            app.ConfigureApi();

            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error", "?code={0}");
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
