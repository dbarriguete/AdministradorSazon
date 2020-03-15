using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdministradorSazon.Startup))]
namespace AdministradorSazon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
