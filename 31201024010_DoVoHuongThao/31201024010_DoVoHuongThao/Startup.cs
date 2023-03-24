using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_31201024010_DoVoHuongThao.Startup))]
namespace _31201024010_DoVoHuongThao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
