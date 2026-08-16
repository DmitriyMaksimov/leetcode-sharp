using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02029))]
public class S02029Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02029();
        Assert.That(sut.StoneGameIX([2, 1]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02029();
        Assert.That(sut.StoneGameIX([2]), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S02029();
        Assert.That(sut.StoneGameIX([5, 1, 2, 4, 3]), Is.False);
    }
}