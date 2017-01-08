using System;
using Nancy;
using Nancy.ModelBinding;
using Nancy.Responses;

namespace NewsSource
{
    public class HomeEndpoint : NancyModule
    {
        public HomeEndpoint()
        {
            Get("/", args => "We are here.");
            Post("/", (args) =>
            {
                return new TextResponse("hello");
            });
        }
    }
}
