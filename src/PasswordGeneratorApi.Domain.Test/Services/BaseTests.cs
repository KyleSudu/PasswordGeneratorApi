using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordGeneratorApi.Application.Factories;
using PasswordGeneratorApi.Application.Services;
using PasswordGeneratorApi.Application.Services.Hashing;
using PasswordGeneratorApi.Domain.Interfaces;
using PasswordGeneratorApi.Domain.Utils;

namespace PasswordGeneratorApi.Domain.Test.Services;

public abstract class BaseTests<T>
{
    protected T Sut => _serviceProvider!.GetRequiredService<T>();
    private IServiceProvider? _serviceProvider { get; set; }
    
    [TestInitialize]
    public virtual void Initialize()
    {
        var host = GetHost();
        _serviceProvider = host.Services.CreateScope().ServiceProvider;
    }
    private IHost GetHost()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((_, services) =>
            {
                services
                    .AddTransient<PasswordGenerator>()
                    .AddTransient<SHA256Hasher>()
                    .AddTransient<IHasherFactory, HasherFactory>()
                    .AddTransient<IRandomNumberGenerator, RandomNumberGenerator>();
            })
            .Build();
    }
}