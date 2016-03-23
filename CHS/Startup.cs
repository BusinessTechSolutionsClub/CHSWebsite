using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CHS.Startup))]
namespace CHS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
