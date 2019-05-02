using KatanaIntro.Components;
using KatanaIntro.Extensions;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

[assembly: OwinStartup(typeof(KatanaIntro.Startup))]

namespace KatanaIntro
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use(async (env, next) =>
            {
                Console.WriteLine("Processing : " + env.Request.Path);

                await next();

                Console.WriteLine("Response : " + env.Response.StatusCode);
            });

            ConfigureWebApi(app);

            //app.Use<HelloWorldComponent>();
            app.UseHelloWorld();

            //app.UseWelcomePage();

            //app.Run(ctx =>
            //{
            //    return ctx.Response.WriteAsync("Hello World 2016 !");
            //});
        }

        private void ConfigureWebApi(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional });
            app.UseWebApi(config);
        }
    }
}
