using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03665))]
public class S03665Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03665();
        Assert.That(sut.UniquePaths([[0, 1, 0], [0, 0, 1], [1, 0, 0]]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03665();
        Assert.That(sut.UniquePaths([[0, 0], [0, 0]]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03665();
        Assert.That(sut.UniquePaths([[0, 1, 1], [1, 1, 0]]), Is.EqualTo(1));
    }
}