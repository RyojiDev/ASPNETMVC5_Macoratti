using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc_CustomizarUsuario.Startup))]
namespace Mvc_CustomizarUsuario
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
