using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EKM.Startup))]
namespace EKM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
