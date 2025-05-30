using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03341))]
public class S03341Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03341();
        Assert.That(sut.MinTimeToReach([[0, 4], [4, 4]]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S03341();
        Assert.That(sut.MinTimeToReach([[0, 0, 0], [0, 0, 0]]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S03341();
        Assert.That(sut.MinTimeToReach([[0, 1], [1, 2]]), Is.EqualTo(3));
    }
}
