using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Converter.Transform;
using Converter.Data;

namespace Converter
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // DI Registrations
            builder.Services.AddScoped<IData, AreaData>();
            builder.Services.AddScoped<IData, LengthData>();
            builder.Services.AddScoped<ITransformer, Transformer>();
            builder.Services.AddSingleton<AppSettings>();

            await builder.Build().RunAsync();
        }
    }
}
