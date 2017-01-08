using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace NewsSource
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("hosting.json", optional: true)
                .Build();

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseConfiguration(config)
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}