using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00342Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00342();
        Assert.That(sut.IsPowerOfFour(16), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00342();
        Assert.That(sut.IsPowerOfFour(5), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00342();
        Assert.That(sut.IsPowerOfFour(1), Is.True);
    }
}
