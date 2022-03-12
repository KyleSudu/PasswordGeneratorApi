using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordGeneratorApi.Domain.Service;

namespace PasswordGeneratorApi.Tests;

[TestClass]
public class SHA256GeneratorTest: BaseTests<SHA256Generator>
{
    [TestInitialize]
    public override void Initialize()
    {
        base.Initialize();
    }


    [TestMethod]
    public void WhenGeneratingPasswords_BasePasswordLengthGreaterThanZero()
    {
        var passwordResponse = Sut.GeneratePassword();
        var isBasePasswordLongEnough = passwordResponse.BasePassword.Length > 0;
        Assert.AreEqual(true, isBasePasswordLongEnough);
    }
}