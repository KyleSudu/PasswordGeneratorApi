using PasswordGeneratorApi.Domain;
using PasswordGeneratorApi.Domain.Web;

namespace PasswordGeneratorApi.DependencyInjection;

public static class ServiceRegistrationExtension
{
    public static IServiceCollection AddDomainServices(this IServiceCollection services)
    {
        return services
            .AddTransient<IPasswordGenerator, NaivePasswordGenerator>()
            .AddTransient<IPasswordGenerator, Md5Generator>()
            .AddTransient<IPasswordGenerator, SHA256Generator>();
    }
}