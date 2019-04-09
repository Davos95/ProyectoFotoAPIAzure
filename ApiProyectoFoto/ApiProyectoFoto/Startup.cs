using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProyectoFoto.Data;
using ApiProyectoFoto.Repositories;
using ApiProyectoFoto.Token;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ApiProyectoFoto
{
    public class Startup
    {
        IConfiguration configuration;
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            HelperToken helpertoken = new HelperToken(this.configuration);

            String cadenaConexionAzure = this.configuration.GetConnectionString("conexionAzure");

            services.AddDbContext<IPictureManagerContext, PictureManagerContext>(options => options.UseSqlServer(cadenaConexionAzure));

            services.AddTransient<IRepositoryComision, RepositoryComision>();
            services.AddTransient<IRepositoryLogin, RepositoryLogin>();
            services.AddTransient<IRepositoryPartner, RepositoryPartner>();
            services.AddTransient<IRepositoryPhoto, RepositoryPhoto>();
            services.AddTransient<IRepositorySesion, RepositorySesion>();
            services.AddTransient<IRepositoryWork, RepositoryWork>();

            services.AddAuthentication(helpertoken.GetAuthOptions()).AddJwtBearer(helpertoken.GetJwtOptions());

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseAuthentication();

            app.UseHttpsRedirection();
            
            app.UseMvc();
        }
    }
}
