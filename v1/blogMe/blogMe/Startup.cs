using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(blogMe.Startup))]
namespace blogMe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
