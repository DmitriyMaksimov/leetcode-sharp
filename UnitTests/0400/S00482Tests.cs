using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00482Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00482();
        Assert.That(sut.LicenseKeyFormatting("5F3Z-2e-9-w", 4), Is.EqualTo("5F3Z-2E9W"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00482();
        Assert.That(sut.LicenseKeyFormatting("2-5g-3-J", 2), Is.EqualTo("2-5G-3J"));
    }
}