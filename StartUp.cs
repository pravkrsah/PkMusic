using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PkMusic.Startup))]
namespace PkMusic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
