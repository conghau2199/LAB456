using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HCH_LAB456.Startup))]
namespace HCH_LAB456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
