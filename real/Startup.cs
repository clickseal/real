using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(real.Startup))]

namespace real
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}