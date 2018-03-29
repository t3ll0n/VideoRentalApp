using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoRentalWebApp.Startup))]
namespace VideoRentalWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
