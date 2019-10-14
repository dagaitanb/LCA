using System.Web.Http;
using WebActivatorEx;
using LCA.WebApi;
using Swashbuckle.Application;
using System;
using System.Reflection;
using System.IO;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace LCA.WebApi
{
    /// <summary>
    /// class SwaggerConfig
    /// </summary>
    public class SwaggerConfig
    {
        /// <summary>
        /// Register
        /// </summary>
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "LCA.WebApi")
                    .Description("Masivian Test Admision - Lowest Common Ancestor - API REST")
                    .Contact(p => p
                      .Name("Diego Alejandro Gaitán")
                      .Url("https://github.com/dagaitanb/LCA")
                      .Email("dalejandro.gaitan@gmail.com"));

                    c.IncludeXmlComments(string.Format(@"{0}\bin\LCA.WebApi.XML",
                           System.AppDomain.CurrentDomain.BaseDirectory));
                })
                .EnableSwaggerUi();
        }
    }
}
