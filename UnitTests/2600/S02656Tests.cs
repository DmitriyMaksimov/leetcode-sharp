using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02656Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02656();
        Assert.That(sut.MaximizeSum([1, 2, 3, 4, 5], 3), Is.EqualTo(18));
    }

    [Test]
    public void T2()
    {
        var sut = new S02656();
        Assert.That(sut.MaximizeSum([5, 5, 5], 2), Is.EqualTo(11));
    }
}