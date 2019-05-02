using KatanaIntro.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace KatanaIntro.Controllers
{
    public class GreetingController : ApiController
    {
        public GreetingViewModel Get()
        {
            return new GreetingViewModel { Text = "Hello from Controller !" };
        }
    }
}
