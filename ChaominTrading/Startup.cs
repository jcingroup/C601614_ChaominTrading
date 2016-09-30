using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChaominTrading.Startup))]
namespace ChaominTrading
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
