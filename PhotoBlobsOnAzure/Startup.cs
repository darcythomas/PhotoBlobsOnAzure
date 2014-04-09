using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhotoBlobsOnAzure.Startup))]
namespace PhotoBlobsOnAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
