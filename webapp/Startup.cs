using Microsoft.Owin;
using Owin;

//aaatest

[assembly: OwinStartupAttribute(typeof(webapp.Startup))]
namespace webapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
