using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02859Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02859();
        Assert.That(sut.SumIndicesWithKSetBits([5, 10, 1, 5, 2], 1), Is.EqualTo(13));
    }

    [Test]
    public void T2()
    {
        var sut = new S02859();
        Assert.That(sut.SumIndicesWithKSetBits([4, 3, 2, 1], 2), Is.EqualTo(1));
    }
}