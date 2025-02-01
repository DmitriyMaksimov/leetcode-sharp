using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00072Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00072();
        Assert.That(sut.MinDistance("horse", "ros"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00072();
        Assert.That(sut.MinDistance("intention", "execution"), Is.EqualTo(5));
    }
}