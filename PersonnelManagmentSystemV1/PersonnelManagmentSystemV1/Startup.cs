using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonnelSystem.Startup))]
namespace PersonnelSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
