using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KatanaIntro.Components
{

    using AppFunc = Func<IDictionary<string, object>, Task>;

    public class HelloWorldComponent
    {
        private AppFunc _next;

        public HelloWorldComponent(AppFunc next)
        {
            _next = next;
        }

        public Task Invoke(IDictionary<string, object> environment)
        {
            var response = environment["owin.ResponseBody"] as Stream;
            using (var writer = new StreamWriter(response))
            {
                return writer.WriteAsync("Hello !!!!!");
            };

            //await _next.Invoke(environment);
        }
    }
}
