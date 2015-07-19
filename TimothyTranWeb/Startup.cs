using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimothyTranWeb.Startup))]
namespace TimothyTranWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
