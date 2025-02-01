using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00693Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00693();
        Assert.That(sut.HasAlternatingBits(5), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00693();
        Assert.That(sut.HasAlternatingBits(7), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00693();
        Assert.That(sut.HasAlternatingBits(11), Is.False);
    }
}
