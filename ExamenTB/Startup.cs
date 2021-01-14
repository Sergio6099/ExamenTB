using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamenTB.Startup))]
namespace ExamenTB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
