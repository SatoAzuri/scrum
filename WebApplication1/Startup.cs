using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace WebApplication1
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
            services.AddMvc()
                .AddMvcOptions(o => o.OutputFormatters.Add(
                    new XmlDataContractSerializerOutputFormatter()));
                ////.AddJsonOptions(o =>
                ////{
                ////    if (o.SerializerSettings.ContractResolver != null)
                ////    {
                ////        var castedResolver = o.SerializerSettings.ContractResolver
                ////            as DefaultContractResolver;
                ////        castedResolver.NamingStrategy = null;
                ////    }
                ////});// ables us to display all elements in the webbrowser using Capital letters as well

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                
                app.UseDeveloperExceptionPage();
            }
            else
            {
                
                app.UseExceptionHandler();
            }

            app.UseStatusCodePages();//ables to use status code arrors
            app.UseMvc();

           /* app.Run(async (context) =>
            {
                await context.Response.WriteAsync("HOME");
            });*/
        }
    }
}
