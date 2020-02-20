﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SampleASPCore.DAL;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.IO;
using Microsoft.Extensions.FileProviders;

namespace SampleASPCore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddSession(options=>{
                options.IdleTimeout = TimeSpan.FromMinutes(2);
            });
            services.AddSingleton<IFileProvider>(  
            new PhysicalFileProvider(  
                Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IDosen,DosenDAL>();
            services.AddScoped<IPengguna,PenggunaDAL>();
            services.AddScoped<IKategori,KategoriDAL>();
            services.AddScoped<IArtikel,ArtikelDAL>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvcWithDefaultRoute();

            /* app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });*/
        }
    }
}
