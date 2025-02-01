using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01869Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01869();
        Assert.That(sut.CheckZeroOnes("1101"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01869();
        Assert.That(sut.CheckZeroOnes("111000"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01869();
        Assert.That(sut.CheckZeroOnes("110100010"), Is.False);
    }
}
