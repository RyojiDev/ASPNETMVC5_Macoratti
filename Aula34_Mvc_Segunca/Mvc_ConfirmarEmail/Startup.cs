using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc_ConfirmarEmail.Startup))]
namespace Mvc_ConfirmarEmail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
