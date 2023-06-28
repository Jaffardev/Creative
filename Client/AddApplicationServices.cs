using Creative.Client.Services;
using Creative.Server.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Refit;

namespace Creative.Client;

public static class ApplicationServicesExtension
{
    public static void AddApplicationService(this WebAssemblyHostBuilder builder)
    {
        builder.Services.AddRefitClient<IRegistrationService>().ConfigureHttpClient((option) => { option.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress); });
        builder.Services.AddRefitClient<ILookupService>().ConfigureHttpClient((option) => { option.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress); });
        builder.Services.AddRefitClient<IParentService>().ConfigureHttpClient((option) => { option.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress); });
    }

}
