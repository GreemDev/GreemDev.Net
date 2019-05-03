using System;
using GreemDev.Files;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Serilog;
using Serilog.Events;

namespace GreemDev
{
    public static class Program
    {
        public static int Main()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();

            try
            {
                Log.Information("Starting web host.");
                Config.CreateIfNotExists();
                CreateWebHostBuilder().Build().Run();
                return 0;
            }
            catch (Exception e)
            {
                Log.Fatal(e, "Host terminated unexpectedly.");
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private static IWebHostBuilder CreateWebHostBuilder() =>
            WebHost.CreateDefaultBuilder()
                .UseSerilog()
                .UseStartup<Startup>();
    }
}