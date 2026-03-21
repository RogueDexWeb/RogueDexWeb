using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RogueDexWeb;
using RogueDexWeb.Models;
using Blazor.SubtleCrypto;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

#if RELEASE
    builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://roguedexweb.github.io/RogueDexWeb/") });
#else
    builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
#endif

builder.Services.AddScoped<ILocalStorageHelper, LocalStorageHelper>();

builder.Services.AddSubtleCrypto();

await builder.Build().RunAsync();
