using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01680Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01680();
        Assert.That(sut.ConcatenatedBinary(1), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01680();
        Assert.That(sut.ConcatenatedBinary(3), Is.EqualTo(27));
    }

    [Test]
    public void T3()
    {
        var sut = new S01680();
        Assert.That(sut.ConcatenatedBinary(12), Is.EqualTo(505379714));
    }
}
