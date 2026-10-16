using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02916))]
public class S02916Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02916();
        Assert.That(sut.SumCounts([1, 2, 1]), Is.EqualTo(15));
    }

    [Test]
    public void T2()
    {
        var sut = new S02916();
        Assert.That(sut.SumCounts([2, 2]), Is.EqualTo(3));
    }
}