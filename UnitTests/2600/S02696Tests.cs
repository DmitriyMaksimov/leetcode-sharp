using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02696Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02696();
        Assert.That(sut.MinLength("ABFCACDB"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02696();
        Assert.That(sut.MinLength("ACBBD"), Is.EqualTo(5));
    }
}