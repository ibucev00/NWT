using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NWT_Rezervacija.Startup))]
namespace NWT_Rezervacija
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
