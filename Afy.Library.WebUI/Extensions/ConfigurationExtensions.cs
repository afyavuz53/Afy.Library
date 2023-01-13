using Afy.Library.WebUI.Models.Options;

namespace Afy.Library.WebUI.Extensions
{
    public static class ConfigurationExtension
    {
        internal static IHostBuilder AddConfigurations(this IHostBuilder host)
        {
            host.ConfigureAppConfiguration((context, config) =>
            {
                var env = context.HostingEnvironment;
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();
            });
            return host;
        }

        internal static IServiceCollection AddOptionConfigure(this IServiceCollection services, IConfiguration config)
        {
            return services.Configure<AppConfig>(config.GetSection(nameof(AppConfig)));
        }
    }
}
