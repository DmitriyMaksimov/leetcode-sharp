using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02048Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02048();
        Assert.That(sut.NextBeautifulNumber(1), Is.EqualTo(22));
    }

    [Test]
    public void T2()
    {
        var sut = new S02048();
        Assert.That(sut.NextBeautifulNumber(1000), Is.EqualTo(1333));
    }

    [Test]
    public void T3()
    {
        var sut = new S02048();
        Assert.That(sut.NextBeautifulNumber(3000), Is.EqualTo(3133));
    }
}
