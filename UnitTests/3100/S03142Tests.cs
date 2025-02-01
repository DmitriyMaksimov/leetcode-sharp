using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03142Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03142();
        Assert.That(sut.SatisfiesConditions([[1, 0, 2], [1, 0, 2]]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03142();
        Assert.That(sut.SatisfiesConditions([[1, 1, 1], [0, 0, 0]]), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S03142();
        Assert.That(sut.SatisfiesConditions([[1], [2], [3]]), Is.False);
    }
}
