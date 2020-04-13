using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.Authorization;

namespace snw55_agricola_blazor_wasm
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services
                .AddBaseAddressHttpClient()
                .AddOptions()
                .AddAuthorizationCore();

            builder.Services.AddScoped<AuthenticationStateProvider, DummyAuthStateProvider>();

            await builder.Build().RunAsync();
        }
    }
}
