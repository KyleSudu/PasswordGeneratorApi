using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordGeneratorApi.Application.Services.Hashing;

namespace PasswordGeneratorApi.Domain.Test.Services;

[TestClass]
public class SHA256HasherTest: BaseTests<SHA256Hasher>
{
    [TestInitialize]
    public override void Initialize()
    {
        base.Initialize();
    }

    [TestMethod]
    public void WhenHashingPasswords_HashedPasswordsDoNotMatch()
    {
        var passwordResponse = Sut.Hash("password");
        Assert.AreNotEqual("password", passwordResponse);
    }
}