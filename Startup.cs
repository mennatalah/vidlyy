using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vidlyy.Startup))]
namespace vidlyy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
