using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02226Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02226();
        Assert.That(sut.MaximumCandies([5, 8, 6], 3), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S02226();
        Assert.That(sut.MaximumCandies([2, 5], 11), Is.EqualTo(0));
    }
}
