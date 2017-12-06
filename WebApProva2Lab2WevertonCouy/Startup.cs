using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApProva2Lab2WevertonCouy.Startup))]
namespace WebApProva2Lab2WevertonCouy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
