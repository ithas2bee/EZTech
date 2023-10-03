using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EZTech.Startup))]
namespace EZTech
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
