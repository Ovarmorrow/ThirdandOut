using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThreeandOut.Startup))]
namespace ThreeandOut
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
