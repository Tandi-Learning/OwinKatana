using KatanaIntro.Components;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KatanaIntro.Extensions
{
    public static class AppBuilderExtensions
    {
        public static void UseHelloWorld(this IAppBuilder app)
        {
            app.Use<HelloWorldComponent>();
        }
    }
}
