using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnotherMVC.Startup))]
namespace AnotherMVC
{

    /*
     * 
     * A comment introduced for review purposes only... i do this quite a lot!
     * 
     */
     
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
