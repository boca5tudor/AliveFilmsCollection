using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AliveFilmCollection.Startup))]
namespace AliveFilmCollection
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
