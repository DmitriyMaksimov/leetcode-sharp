using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00869Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00869();
        Assert.That(sut.ReorderedPowerOf2(1), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00869();
        Assert.That(sut.ReorderedPowerOf2(10), Is.False);
    }
}
