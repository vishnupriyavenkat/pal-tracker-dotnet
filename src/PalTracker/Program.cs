﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Steeltoe.Extensions.Configuration.CloudFoundry;

namespace PalTracker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) => WebHostBuilder(args).Build();
        public static IWebHostBuilder WebHostBuilder(string[] args) => WebHost.CreateDefaultBuilder(args).ConfigureAppConfiguration(config => config.AddCloudFoundry()).UseStartup<Startup>();
    }
}
