using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IndividualLabAssignment.Startup))]
namespace IndividualLabAssignment
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
