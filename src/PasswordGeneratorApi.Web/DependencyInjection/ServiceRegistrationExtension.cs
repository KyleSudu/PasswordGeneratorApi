using PasswordGeneratorApi.Application.Factories;
using PasswordGeneratorApi.Application.Services;
using PasswordGeneratorApi.Application.Services.Hashing;
using PasswordGeneratorApi.Domain.Interfaces;
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