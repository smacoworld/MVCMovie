using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmacoWorld.Sample.BalanceSheet.Startup))]
namespace SmacoWorld.Sample.BalanceSheet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
