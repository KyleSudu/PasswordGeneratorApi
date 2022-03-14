using PasswordGeneratorApi.Domain;
using PasswordGeneratorApi.Domain.Service;
using PasswordGeneratorApi.Domain.Utils;
using PasswordGeneratorApi.Domain.Web;

namespace PasswordGeneratorApi.DependencyInjection;

public static class ServiceRegistrationExtension
{
    public static IServiceCollection AddDomainServices(this IServiceCollection services)
    {
        return services
            .AddTransient<BasePasswordGenerator>()
            .AddTransient<NaivePasswordGenerator>()
            .AddTransient<Md5Generator>()
            .AddTransient<IPasswordGeneratorFactory, PasswordGeneratorFactory>()
            .AddTransient<SHA256Generator>();
    }
}