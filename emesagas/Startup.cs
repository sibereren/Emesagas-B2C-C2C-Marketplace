using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(emesagas.Startup))]
namespace emesagas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
