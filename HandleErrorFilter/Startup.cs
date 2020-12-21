using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HandleErrorFilter.Startup))]
namespace HandleErrorFilter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
