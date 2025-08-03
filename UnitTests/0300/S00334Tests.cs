using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00334Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00334();
        Assert.That(sut.IncreasingTriplet([1, 2, 3, 4, 5]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00334();
        Assert.That(sut.IncreasingTriplet([5, 4, 3, 2, 1]), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00334();
        Assert.That(sut.IncreasingTriplet([2, 1, 5, 0, 4, 6]), Is.True);
    }
}
