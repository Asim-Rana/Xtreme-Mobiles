using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XtremeMobiles.Startup))]
namespace XtremeMobiles
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
