using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoeStoreTeam.Startup))]
namespace ShoeStoreTeam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
