using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Test123MobileAppService.Startup))]

namespace Test123MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}