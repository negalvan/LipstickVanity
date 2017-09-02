using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LipstickVanity.Startup))]
namespace LipstickVanity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
