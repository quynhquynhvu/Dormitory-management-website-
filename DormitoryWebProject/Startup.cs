using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DormitoryWebProject.Startup))]
namespace DormitoryWebProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
