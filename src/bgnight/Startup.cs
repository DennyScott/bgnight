using Microsoft.AspNetCore.Builder;
using Nancy;
using Nancy.Configuration;
using Nancy.Owin;

namespace NewsSource
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseOwin(x => x.UseNancy());
        }

    }
}