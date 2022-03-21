using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordGeneratorApi.Application.Services;

namespace PasswordGeneratorApi.Domain.Test.Services;

[TestClass]
public class BasePasswordGeneratorTest: BaseTests<PasswordGenerator>
{
    [TestInitialize]
    public override void Initialize()
    {
        base.Initialize();
    }

    [TestMethod]
    public void WhenGeneratingPasswords_WithSHA256Hashing_BasePasswordLengthGreaterThanZero()
    {
        var passwordResponse = Sut.GeneratePassword("SHA256");
        var isBasePasswordLongEnough = passwordResponse.BasePassword.Length > 0;
        Assert.AreEqual(true, isBasePasswordLongEnough);
    }
}