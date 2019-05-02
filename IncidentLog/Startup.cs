using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IncidentLog.Startup))]
namespace IncidentLog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
