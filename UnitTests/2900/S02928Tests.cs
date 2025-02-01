using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02928Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02928();
        Assert.That(sut.DistributeCandies(5, 2), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02928();
        Assert.That(sut.DistributeCandies(3, 3), Is.EqualTo(10));
    }
}