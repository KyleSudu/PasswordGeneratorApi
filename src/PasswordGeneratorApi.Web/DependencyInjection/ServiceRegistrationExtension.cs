using PasswordGeneratorApi.Domain;
using PasswordGeneratorApi.Domain.Interfaces;
using PasswordGeneratorApi.Domain.Service;
using PasswordGeneratorApi.Domain.Service.Hashing;
using PasswordGeneratorApi.Domain.Utils;
using PasswordGeneratorApi.Domain.Web;

namespace PasswordGeneratorApi.DependencyInjection;

public static class ServiceRegistrationExtension
{
    public static IServiceCollection AddDomainServices(this IServiceCollection services)
    {
        return services
            .AddTransient<BasePasswordGenerator>()
            .AddTransient<NaiveHasher>()
            .AddTransient<Md5Generator>()
            .AddTransient<IPasswordGenerator, PasswordGenerator>()
            .AddTransient<IHasherFactory, HasherFactory>()
            .AddTransient<IRandomNumberGenerator, RandomNumberGenerator>()
            .AddTransient<SHA256Generator>();
    }
}