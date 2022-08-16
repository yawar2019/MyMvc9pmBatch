using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ErrorHandleFilter.Startup))]
namespace ErrorHandleFilter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
