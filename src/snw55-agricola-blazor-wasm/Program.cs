using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Blazor.Auth0;
using Blazor.Extensions.Storage;

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
                .AddBlazorAuth0(options =>
                {                   
                    options.Domain = "snw55.eu.auth0.com";
                    options.ClientId = "5DUd6KS3qMsRmRRvZpKQRm9fG2T6iARS";
                    options.RequireAuthenticatedUser = false;
                })
                .AddAuthorizationCore()
                .AddStorage();

            await builder.Build().RunAsync();
        }
    }
}
