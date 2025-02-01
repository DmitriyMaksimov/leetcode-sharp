using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01283Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01283();
        Assert.That(sut.SmallestDivisor([1, 2, 5, 9], 6), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S01283();
        Assert.That(sut.SmallestDivisor([44, 22, 33, 11, 1], 5), Is.EqualTo(44));
    }
}
