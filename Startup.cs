using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blood_Donation_Management_System.Startup))]
namespace Blood_Donation_Management_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
