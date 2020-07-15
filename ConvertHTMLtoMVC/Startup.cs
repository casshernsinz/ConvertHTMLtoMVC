using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConvertHTMLtoMVC.Startup))]
namespace ConvertHTMLtoMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
