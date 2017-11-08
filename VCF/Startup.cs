using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VCF.Startup))]
namespace VCF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
