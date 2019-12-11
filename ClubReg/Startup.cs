using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClubReg.Startup))]
namespace ClubReg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
