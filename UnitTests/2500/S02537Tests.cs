using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02537Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02537();
        Assert.That(sut.CountGood([1, 1, 1, 1, 1], 10), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02537();
        Assert.That(sut.CountGood([3, 1, 4, 3, 2, 2, 4], 2), Is.EqualTo(4));
    }
}
