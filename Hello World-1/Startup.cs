using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hello_World_1.Startup))]
namespace Hello_World_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
