using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace Sample.Blog.BlazorWebAssembly
{
    public class Program
    {
        public static IConfiguration Configuration { get; }

        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddBaseAddressHttpClient();

            builder.Services.AddOptions<IOptions<Models.AppOptions>>();
            builder.Services.AddSingleton<Models.IApiClient, Models.ApiClient>();

            await builder.Build().RunAsync();
        }
    }
}
