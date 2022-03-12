using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PasswordGeneratorApi.DependencyInjection;

namespace PasswordGeneratorApi.Tests;

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
        var randomGenerator = new Mock<Random>();

        return Host.CreateDefaultBuilder()
            .ConfigureServices((_, services) =>
            {
                services.AddDomainServices()
                    .TryAddSingleton<Random>();
            })
            .Build();
    }
}