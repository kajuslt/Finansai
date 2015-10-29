using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Finanasai.Startup))]
namespace Finanasai
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
