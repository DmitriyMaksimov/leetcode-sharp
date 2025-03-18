using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03342Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03342();
        Assert.That(sut.MinTimeToReach([[0, 4], [4, 4]]), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S03342();
        Assert.That(sut.MinTimeToReach([[0, 0, 0, 0], [0, 0, 0, 0]]), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S03342();
        Assert.That(sut.MinTimeToReach([[0, 1], [1, 2]]), Is.EqualTo(4));
    }
}
