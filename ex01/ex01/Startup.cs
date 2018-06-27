using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ex01.Startup))]
namespace ex01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
