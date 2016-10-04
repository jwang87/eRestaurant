using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eRestaurantWeb.Startup))]
namespace eRestaurantWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
