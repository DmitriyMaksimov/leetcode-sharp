using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02597Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02597();
        Assert.That(sut.BeautifulSubsets([2, 4, 6], 2), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02597();
        Assert.That(sut.BeautifulSubsets([1], 1), Is.EqualTo(1));
    }
}