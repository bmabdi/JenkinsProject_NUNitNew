using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsProject_NUNit.Startup))]
namespace JenkinsProject_NUNit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
