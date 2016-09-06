using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Patient_History.Startup))]
namespace Patient_History
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
