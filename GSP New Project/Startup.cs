using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GSPNewProject.Startup))]
namespace GSPNewProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
