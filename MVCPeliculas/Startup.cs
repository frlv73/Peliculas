using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPeliculas.Startup))]
namespace MVCPeliculas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
