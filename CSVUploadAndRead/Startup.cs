using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSVUploadAndRead.Startup))]
namespace CSVUploadAndRead
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
