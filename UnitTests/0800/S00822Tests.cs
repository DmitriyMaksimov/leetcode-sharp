using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00822))]
public class S00822Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00822();
        Assert.That(sut.Flipgame([1, 2, 4, 4, 7], [1, 3, 4, 1, 3]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00822();
        Assert.That(sut.Flipgame([1], [1]), Is.EqualTo(0));
    }
}