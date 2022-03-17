using PasswordGeneratorApi.Domain.Interfaces;
using PasswordGeneratorApi.Domain.Service;
using PasswordGeneratorApi.Domain.Service.Hashing;
using PasswordGeneratorApi.Domain.Utils;

namespace PasswordGeneratorApi.DependencyInjection;
public static class ServiceRegistrationExtension
{
    public static void AddDomainServices(this IServiceCollection services)
    {
        services
            .AddTransient<NaiveHasher>()
            .AddTransient<Md5Hasher>()
            .AddTransient<SHA256Hasher>()
            .AddTransient<IPasswordGenerator, PasswordGenerator>()
            .AddTransient<IHasherFactory, HasherFactory>()
            .AddTransient<IRandomNumberGenerator, RandomNumberGenerator>();
    }
}