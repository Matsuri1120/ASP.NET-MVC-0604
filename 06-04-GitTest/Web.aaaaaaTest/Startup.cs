using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.aaaaaaTest.Startup))]
namespace Web.aaaaaaTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
