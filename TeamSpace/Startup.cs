using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamSpace.Startup))]
namespace TeamSpace
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
